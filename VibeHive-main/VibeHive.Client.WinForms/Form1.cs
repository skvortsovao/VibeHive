using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace VibeHive.Client.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnNavMusic.Click += btnNavMusic_Click;
            btnNavEvents.Click += btnNavEvents_Click;

            RefreshLists();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMusic.Visible = false;
            panelEvents.Visible = false;


            panelMusic.Dock = DockStyle.Fill;
            panelEvents.Dock = DockStyle.Fill;
        }


        private void ShowOnly(Panel target)
        {
            panelMusic.Visible = false;
            panelEvents.Visible = false;

            target.Visible = true;
            target.BringToFront();

            btnNavMusic.Enabled = target != panelMusic;
            btnNavEvents.Enabled = target != panelEvents;
        }

        private void btnNavMusic_Click(object sender, EventArgs e)
        {
            ShowOnly(panelMusic);
        }

        private void btnNavEvents_Click(object sender, EventArgs e)
        {
            ShowOnly(panelEvents);
        }

        private void btnMusicAction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will open the Music Rentals UI later (Point 1).", "Coming soon");
        }

        private void btnEventsAction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will open the Events & Tickets UI later (Point 3).", "Coming soon");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnEventsAction_Click(sender, e);
        }
        private void lblMusic_Click(object sender, EventArgs e)
        {

        }

        //CONTENT WARNING: SPAGHETTI CODE
        private static readonly HttpClient _httpClient = new HttpClient();
        private async void RefreshLists()
        {
            try
            {
                //allow use of albums later
                var albums = new List<Album>();
                //clear listbox for albums
                albumList.Items.Clear();
                HttpResponseMessage message = await _httpClient.GetAsync("https://localhost:7245/api/Album");
                if (message.IsSuccessStatusCode)
                {
                    //Read response as string, turn into list, add to listbox
                    string jsonString = await message.Content.ReadAsStringAsync();
                    albums = JsonConvert.DeserializeObject<List<Album>>(jsonString);
                    foreach (Album item in albums)
                    {
                        albumList.Items.Add($"{item.ID}:{item.Title} Artist: {item.Artist} Genre: {item.Genre} Year: {item.Year} (Available:{item.Available})");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve albums", "Error");
                }

                //clear listbox for rentals
                rentalList.Items.Clear();
                HttpResponseMessage message3 = await _httpClient.GetAsync("https://localhost:7201/api/Rental");
                if (message3.IsSuccessStatusCode)
                {
                    //Read response as string, turn into array, add to list
                    string jsonString = await message3.Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<List<Rental>>(jsonString);
                    foreach (Rental item in items)
                    {
                        //since rental tracks IDs not Names, we need to get those. dont do an api call everytime those are slower!
                        var userName = item.UserId.ToString();
                        // SALLY, refer to this code for displaying a user's name if you need to.
                        // it should work if you store users in a list of users.
                        // ask any questions about this if you need too
                        //var wanted = customers.Find(x => x.ID == item.UserId);
                        //if (wanted != null)
                        //{
                        //    userName = wanted.Name;
                        //}
                        var albumName = item.AlbumId.ToString();
                        var wanted2 = albums.Find(x => x.ID == item.AlbumId);
                        if (wanted2 != null)
                        {
                            albumName = wanted2.Title;
                        }
                        if (item.ReturnDate != null)
                        {
                            rentalList.Items.Add($"{item.ID}: User: {userName} Album: {albumName} Rent Date: {item.RentalTime.ToString()} (Return Date:{item.ReturnDate.ToString()})");
                        }
                        else
                        {
                            rentalList.Items.Add($"{item.ID}: User: {userName} Album: {albumName} Rent Date: {item.RentalTime.ToString()} (Return Date:NOT RETURNED)");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve rentals", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error! D: " + ex.ToString(), "Error");
            }
        }

        private async void newAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                //check for empties
                if (newAlbumTitle.Text.Trim() == "" || newAlbumArtist.Text.Trim() == "" || newAlbumGenre.Text.Trim() == "" || int.Parse(newAlbumYear.Text) == 0)
                {
                    MessageBox.Show("Please fill out all values", "Error");
                    return;
                }
                // Create an object for the album. Same name as it appears in the API
                var newAlbum = new
                {
                    Title = newAlbumTitle.Text,
                    Artist = newAlbumArtist.Text,
                    Genre = newAlbumGenre.Text,
                    Year = int.Parse(newAlbumYear.Text),
                };

                // Manually serialize the object to JSON
                var json = JsonConvert.SerializeObject(newAlbum);

                // Create HttpContent with Json string
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request
                HttpResponseMessage message = await _httpClient.PostAsync("https://localhost:7245/api/Album", content);

                if (message.IsSuccessStatusCode)
                {
                    MessageBox.Show("Album Added Successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to add the album!", "Error");
                }
                RefreshLists();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error! D: " + ex.ToString(), "Error");
            }
        }

        private async void rentAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage message2 = await _httpClient.GetAsync($"https://localhost:7245/api/Album/{int.Parse(rentalAlbumID.Text)}");
                if (message2.IsSuccessStatusCode)
                {
                    //Read response as string, turn into list, add to listbox
                    string jsonString2 = await message2.Content.ReadAsStringAsync();
                    var album = JsonConvert.DeserializeObject<Album>(jsonString2);
                    if (album == null)
                    {
                        MessageBox.Show("No matching album ID.", "Error");
                        return;
                    }
                    if (album.Available == false)
                    {
                        MessageBox.Show("Album not available to rent.", "Error");
                        return;
                    }

                    // Create an object for the book. Same name as it appears in the API
                    var newRental = new
                    {
                        UserId = int.Parse(rentalUserID.Text), //SALLY, this is temporary until users are actually added.
                        AlbumId = album.ID,
                    };

                    // Manually serialize the object to JSON
                    var json = JsonConvert.SerializeObject(newRental);

                    // Create HttpContent with Json string
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Send the POST request
                    HttpResponseMessage message3 = await _httpClient.PostAsync("https://localhost:7201/api/Rental", content);

                    if (message3.IsSuccessStatusCode)
                    {
                        // Return made. Now we need to set album availability to false.
                        // Manually serialize the object to JSON
                        var json2 = JsonConvert.SerializeObject(album.ID);

                        // Create HttpContent with Json string
                        var content2 = new StringContent(json2, Encoding.UTF8, "application/json");

                        // Send the POST request
                        HttpResponseMessage message4 = await _httpClient.PostAsync($"https://localhost:7245/api/Album/{album.ID}", content2);

                        if (message4.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Rental Added Successfully!", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Cannot swap album to be unavailable!", "Error");
                        }
                        RefreshLists();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the rental!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve albums", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error! D: " + ex.ToString(), "Error");
            }
        }

        private async void returnAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Manually serialize the object to JSON
                var json = JsonConvert.SerializeObject(int.Parse(returnID.Text));

                // Create HttpContent with Json string
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request
                HttpResponseMessage message = await _httpClient.PostAsync($"https://localhost:7201/api/Rental/{int.Parse(returnID.Text)}/return", content);
                if (message.IsSuccessStatusCode)
                {
                    //returned! now to find the rental, find the album from the rental's id, then set its availability to true
                    HttpResponseMessage message2 = await _httpClient.GetAsync($"https://localhost:7201/api/Rental/{int.Parse(returnID.Text)}");
                    if (message2.IsSuccessStatusCode)
                    {
                        //Read response as string, turn into list, add to listbox
                        string jsonString = await message2.Content.ReadAsStringAsync();
                        var rental = JsonConvert.DeserializeObject<Rental>(jsonString);
                        var rentedAlbumID = rental.AlbumId;
                        HttpResponseMessage message3 = await _httpClient.GetAsync($"https://localhost:7245/api/Album/{rentedAlbumID}");
                        if (message3.IsSuccessStatusCode)
                        {
                            //Read response as string, turn into list, add to listbox
                            string jsonString2 = await message3.Content.ReadAsStringAsync();
                            var album = JsonConvert.DeserializeObject<Album>(jsonString2);
                            if (album == null)
                            {
                                MessageBox.Show("No matching album ID?", "Error");
                                return;
                            }
                            if (album.Available == true)
                            {
                                MessageBox.Show("Album is already available?", "Error");
                                return;
                            }
                            // Manually serialize the object to JSON
                            var json2 = JsonConvert.SerializeObject(album.ID);

                            // Create HttpContent with Json string
                            var content2 = new StringContent(json2, Encoding.UTF8, "application/json");

                            // Send the POST request
                            HttpResponseMessage message4 = await _httpClient.PostAsync($"https://localhost:7245/api/Album/{album.ID}", content2);

                            if (message4.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Album returned Successfully!", "Success");
                            }
                            else
                            {
                                MessageBox.Show("Cannot swap album to be unavailable!", "Error");
                            }
                            RefreshLists();
                        }
                        else
                        {
                            MessageBox.Show("Cant connect to albums", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cant connect to rentals?", "Error");
                    }

                }
                else
                {
                    MessageBox.Show("Failed to return album. Album might already be returned.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error! D: " + ex.ToString(), "Error");
            }
        }

        private async void deleteAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage message2 = await _httpClient.GetAsync($"https://localhost:7245/api/Album/{int.Parse(rentalAlbumID.Text)}");
                if (message2.IsSuccessStatusCode)
                {
                    //Read response as string, turn into list, add to listbox
                    string jsonString2 = await message2.Content.ReadAsStringAsync();
                    var album = JsonConvert.DeserializeObject<Album>(jsonString2);
                    if (album == null)
                    {
                        MessageBox.Show("No matching album ID.", "Error");
                        return;
                    }
                    HttpResponseMessage message3 = await _httpClient.DeleteAsync($"https://localhost:7245/api/Album/{int.Parse(rentalAlbumID.Text)}");
                    if (message3.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Deleted album", "Success");
                        RefreshLists();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete album", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve albums", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error! D: " + ex.ToString(), "Error");
            }
        }
    }
}