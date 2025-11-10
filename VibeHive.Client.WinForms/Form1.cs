using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using VibeHive.Client.WinForms.DTO;
using VibeHive.Client.WinForms.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;




namespace VibeHive.Client.WinForms
{
    public partial class Form1 : Form

    {
        private readonly HttpClient _eventsHttp = new()
        {
            BaseAddress = new Uri("https://localhost:7273")
        };
        // session state for the logged-in user
        private string? _jwt;
        private int _currentUserId;
        private string _currentRole = "User";
        private string _currentUserName = "";
        private bool _eventsUiInited = false;
        // which kind of data the grid is currently showing
        private enum GridMode { Events, Tickets, AdminTickets }
        private GridMode _gridMode = GridMode.Events;

        public Form1()
        {
            InitializeComponent();
            // wire up top-level navigation and set defaults
            this.Load += Form1_Load;
            btnNavMusic.Click += btnNavMusic_Click;
            btnNavEvents.Click += btnNavEvents_Click;
            numBookQty.Minimum = 1;
            numBookQty.Value = 1;


            RefreshLists();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // nothing shown except the auth menu
            panelMusic.Visible = false;
            panelEvents.Visible = false;

            grpDashboard.Visible = false;
            grpRegister.Visible = false;
            grpLogin.Visible = false;
            grpAuthMenu.Visible = true;

            // hide nav buttons until login
            SetNavVisible(false);

            // roles for registration
            cmbRegRole.Items.AddRange(new[] { "User", "EventManager", "Admin" });
            cmbRegRole.SelectedIndex = 0;

            // wire the auth menu/login/register/dashboard buttons immediately
            InitEventsUiOnce();

            // Start on the auth menu
            ShowEventsView(EventsView.Menu);
            UpdateTopBar();
        }
        private void UpdateTopBar()
        {
            bool loggedIn = _jwt != null;

            // existing nav buttons
            btnNavMusic.Visible = loggedIn;
            btnNavEvents.Visible = loggedIn;
            btnNavMusic.Enabled = loggedIn;
            btnNavEvents.Enabled = loggedIn;

            // top labels + logout button (assumes these controls are on the top bar)
            lblWelcome.Visible = loggedIn;
            lblUserIdNav.Visible = loggedIn;
            btnLogout.Visible = loggedIn;

            lblWelcome.Text = loggedIn ? $"Welcome, {_currentUserName}" : "";
            lblUserIdNav.Text = loggedIn ? $"User ID: {_currentUserId}" : "";
        }
        private void BindMusicUser()
        {
            // keep the Music tab’s UserID always = logged-in user
            if (rentalUserID == null) return;

            if (_jwt == null || _currentUserId <= 0)
            {
                rentalUserID.Text = "";
                rentalUserID.ReadOnly = true;   // not logged in -> can’t type either
                return;
            }

            rentalUserID.Text = _currentUserId.ToString();
            rentalUserID.ReadOnly = true;       // logged in -> lock to real id
        }
        private void SetNavVisible(bool on)
        {
            btnNavMusic.Visible = on;
            btnNavEvents.Visible = on;
            btnNavMusic.Enabled = on;
            btnNavEvents.Enabled = on;
        }
        // logical views inside the events panel
        private enum EventsView { Menu, Register, Login, Dashboard }


        private void btnNavEvents_Click(object sender, EventArgs e)
        {
            ShowOnly(panelEvents);
            InitEventsUiOnce();
            ShowEventsView(_jwt is null ? EventsView.Menu : EventsView.Dashboard);
        }
        private async void btnRegisterConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //collect registration data (role is restricted by combo box)
                var body = new
                {
                    name = txtRegName.Text,
                    email = txtRegEmail.Text,
                    password = txtRegPassword.Text,
                    role = cmbRegRole.SelectedItem?.ToString() ?? "User"
                };

                // call api to register
                var res = await _eventsHttp.PostAsJsonAsync("/api/users/register", body);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registration successful! You can log in now.");
                    txtRegPassword.Clear();
                    ShowEventsView(EventsView.Menu);
                }
                else
                {
                    MessageBox.Show("Registration failed: " + await res.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnLoginConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // call API to login and get JWT
                var res = await _eventsHttp.PostAsJsonAsync("/api/auth/login", new
                {
                    email = txtLoginEmail.Text,
                    password = txtLoginPassword.Text
                });

                if (!res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Invalid credentials.");
                    return;
                }

                //  read login payload
                var data = await res.Content.ReadFromJsonAsync<LoginResponse>();
                if (data == null)
                {
                    MessageBox.Show("Empty response.");
                    return;
                }

                //  store session
                _jwt = data.token;
                _currentUserId = data.id;
                _currentRole = data.role;

                //  set auth header
                _eventsHttp.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _jwt);

                // read "name" from JWT claims (fallback to email if absent)
                var handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(_jwt);

                _currentUserName =
                    token.Claims.FirstOrDefault(c =>
                        c.Type == ClaimTypes.Name || c.Type == "name" || c.Type == "unique_name" || c.Type == "username")
                    ?.Value
                    ?? txtLoginEmail.Text;

               


                // update top bar + nav visibility
                UpdateTopBar();
                BindMusicUser();
                //  hide auth UI
                grpAuthMenu.Visible = false;
                grpRegister.Visible = false;
                grpLogin.Visible = false;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private async Task LoadEventsAsync()
        {
            try
            {
                // show events list in the grid
                _gridMode = GridMode.Events;
                gridEvents.AutoGenerateColumns = true;
                gridEvents.Columns.Clear();

                var list = await _eventsHttp.GetFromJsonAsync<List<EventView>>("/api/events");
                gridEvents.DataSource = list ?? new List<EventView>();
                if (gridEvents.Rows.Count > 0) gridEvents.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load events: " + ex.Message);
            }
        }
        private void ShowEventsView(EventsView v)
        {
            // hide all three, then show the requested one
            grpAuthMenu.Visible = false;
            grpRegister.Visible = false;
            grpLogin.Visible = false;
            grpDashboard.Visible = false;

            switch (v)
            {
                case EventsView.Menu:
                    grpAuthMenu.Visible = true;
                    grpAuthMenu.BringToFront();
                    break;
                case EventsView.Register:
                    grpRegister.Visible = true;
                    grpRegister.BringToFront();
                    break;
                case EventsView.Login:
                    grpLogin.Visible = true;
                    grpLogin.BringToFront();
                    break;
                case EventsView.Dashboard:
                    grpDashboard.Visible = true;
                    grpDashboard.BringToFront();
                    ApplyRoleUi();// adjust buttons by role
                    break;
            }
        }
        private void ApplyRoleUi()
        {
            bool canCreate = _currentRole == "Admin" || _currentRole == "EventManager";  // only admins and event managers can create events or see admin controls
            btnCreateEvent.Enabled = canCreate;

            // toggle admin/event-manager tools
            btnAdminAllBookings.Visible = canCreate;
            btnAdminSetBooked.Visible = canCreate;
            btnAdminSetCancelled.Visible = canCreate;
            // event creation inputs
            txtEventName.Visible = canCreate;
            label14.Visible = canCreate;
            label15.Visible = canCreate;
            txtEventVenue.Visible = canCreate;
            label16.Visible = canCreate;
            txtEventGenre.Visible = canCreate;
            dtEventDate.Visible = canCreate;
            label17.Visible = canCreate;
            numEventTickets.Visible = canCreate;
            btnCreateEvent.Visible = canCreate;
        }
        private void InitEventsUiOnce()
        {
            if (_eventsUiInited) return;

            // Menu
            btnMenuRegister.Click += (_, __) => ShowEventsView(EventsView.Register);
            btnMenuLogin.Click += (_, __) => ShowEventsView(EventsView.Login);

            // Register
            btnRegisterCancel.Click += (_, __) => ShowEventsView(EventsView.Menu);
            btnRegisterConfirm.Click += btnRegisterConfirm_Click;

            // Login
            btnLoginCancel.Click += (_, __) => ShowEventsView(EventsView.Menu);
            btnLoginConfirm.Click += btnLoginConfirm_Click;

            // Dashboard
            btnLoadEvents.Click += btnLoadEvents_Click;
            btnCreateEvent.Click += btnCreateEvent_Click;
            btnBookTicket.Click += btnBookTicket_Click;
            gridEvents.SelectionChanged += gridEvents_SelectionChanged;
            if (btnCancelSelected is not null) btnCancelSelected.Click += btnCancelSelected_Click;
            // common actions
            if (btnMyTickets is not null) btnMyTickets.Click += btnMyTickets_Click;
            if (btnLogout is not null) btnLogout.Click += btnLogout_Click;
            if (btnAdminAllBookings is not null) btnAdminAllBookings.Click += async (_, __) => await LoadAllBookingsAsync();
            if (btnAdminSetBooked is not null) btnAdminSetBooked.Click += async (_, __) => await AdminSetStatusOnSelectedAsync("Booked");
            if (btnAdminSetCancelled is not null) btnAdminSetCancelled.Click += async (_, __) => await AdminSetStatusOnSelectedAsync("Cancelled");

            // default screen when user enters the Events tab
            ShowEventsView(EventsView.Menu);
            _eventsUiInited = true;
        }
        private async Task LoadAllBookingsAsync()
        {
            try
            {
                //switch grid to admin view
                _gridMode = GridMode.AdminTickets;
                // get all tickets (admin endpoint)
                var tickets = await _eventsHttp.GetFromJsonAsync<List<TicketDto>>("/api/tickets")
                              ?? new List<TicketDto>();
                //ticket rows with event info (name, date, venue)
                var events = await _eventsHttp.GetFromJsonAsync<List<EventView>>("/api/events")
                              ?? new List<EventView>();
                var byId = events.ToDictionary(e => e.Id);

                var rows = tickets.Select(t =>
                {
                    byId.TryGetValue(t.EventId, out var ev);
                    return new TicketView
                    {
                        Id = t.Id,
                        EventId = t.EventId,
                        Event = ev?.Name ?? $"#{t.EventId}",
                        Date = ev?.Date ?? default,
                        Venue = ev?.Venue ?? "",
                        Status = t.Status
                    };
                }).ToList();

                gridEvents.AutoGenerateColumns = true;
                gridEvents.Columns.Clear();
                gridEvents.DataSource = rows;
                if (gridEvents.Rows.Count > 0) gridEvents.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load all bookings: " + ex.Message);
            }
        }
        private async Task AdminSetStatusOnSelectedAsync(string newStatus)
        {
            //change status (booked/cancelled) for selected rows when in admin mode
            if (_jwt is null) { MessageBox.Show("Login first."); return; }
            if (_gridMode != GridMode.AdminTickets)
            {
                MessageBox.Show("Click 'All Bookings' first to switch the grid.");
                return;
            }

            var selected = gridEvents.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as TicketView)
                .Where(tv => tv is not null)
                .ToList();

            if (selected.Count == 0)
            {
                MessageBox.Show("Select at least one ticket row.");
                return;
            }

            int ok = 0;
            foreach (var tv in selected)
            {
                var res = await _eventsHttp.PostAsJsonAsync($"/api/tickets/{tv!.Id}/set-status",
                    new { Status = newStatus });
                if (res.IsSuccessStatusCode) ok++;
            }

            MessageBox.Show($"Updated {ok} / {selected.Count} ticket(s) to {newStatus}.");

            // refresh admin bookings and events (availability)
            await LoadAllBookingsAsync();
            await LoadEventsAsync();
        }
        
       

        private async void btnLoadEvents_Click(object sender, EventArgs e) => await LoadEventsAsync();

        private async void btnCreateEvent_Click(object sender, EventArgs e)
        {
            // create event (admin/event manager only)
            if (_jwt is null) { MessageBox.Show("Login first."); return; }

            var body = new
            {
                name = txtEventName.Text,
                date = dtEventDate.Value,
                venue = txtEventVenue.Text,
                genre = txtEventGenre.Text,
                availableTickets = (int)numEventTickets.Value
            };

            var res = await _eventsHttp.PostAsJsonAsync("/api/events", body);
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Event created.");
                await LoadEventsAsync();
            }
            else
            {
                MessageBox.Show("Create failed (need Admin/EventManager?): " + await res.Content.ReadAsStringAsync());
            }
        }
        private void gridEvents_SelectionChanged(object? sender, EventArgs e)
        {
            // update booking ui based on selected event and its availability
            var ev = gridEvents.CurrentRow?.DataBoundItem as EventView;

            if (ev is null)
            {
                numBookQty.Enabled = false;
                numBookQty.Maximum = 1;
                numBookQty.Value = 1;
                lblAvail.Text = "";
                btnBookTicket.Enabled = false;
                return;
            }

            int available = Math.Max(0, ev.AvailableTickets);

            if (available <= 0)
            {
                // sold out state
                numBookQty.Enabled = false;
                numBookQty.Maximum = 1;
                numBookQty.Value = 1;      // always reset to 1
                lblAvail.Text = "Available: 0 (Sold out)";
                btnBookTicket.Enabled = false;
                return;
            }

            // Tickets available
            numBookQty.Enabled = true;
            numBookQty.Maximum = available;
            numBookQty.Value = 1;          // reset to one each selection
            lblAvail.Text = $"Available: {available}";
            btnBookTicket.Enabled = true;
        }

        private async void btnBookTicket_Click(object sender, EventArgs e)
        {
            // book N tickets (looping because api books one per call)
            if (_jwt is null) { MessageBox.Show("Login first."); return; }

            var ev = gridEvents.CurrentRow?.DataBoundItem as EventView;
            if (ev is null) { MessageBox.Show("Select an event."); return; }

            int qty = (int)numBookQty.Value;
            // quick client-side guard
            if (qty <= 0) { MessageBox.Show("Quantity must be at least 1."); return; }


            if (qty > ev.AvailableTickets)
            {
                MessageBox.Show($"Only {ev.AvailableTickets} ticket(s) are available for \"{ev.Name}\".");
                return;
            }


            int success = 0;
            for (int i = 0; i < qty; i++)
            {
                var res = await _eventsHttp.PostAsJsonAsync("/api/tickets",
                    new { EventId = ev.Id, UserId = _currentUserId });

                if (!res.IsSuccessStatusCode)
                {
                    var msg = await res.Content.ReadAsStringAsync();
                    MessageBox.Show($"Booking stopped after {success} ticket(s). Server said: {msg}");
                    break;
                }
                success++;
            }

            if (success > 0)
                MessageBox.Show($"Booked {success} ticket(s) for \"{ev.Name}\".");

            // refresh to show updated availability
            await LoadEventsAsync();
        }

        private async void btnMyTickets_Click(object sender, EventArgs e)
        {
            await LoadMyTicketsAsync();
        }

        private void ShowOnly(Panel target)
        {
            //show only the requested main panel
            panelMusic.Visible = false;
            panelEvents.Visible = false;

            target.Visible = true;
            target.BringToFront();

            btnNavMusic.Enabled = target != panelMusic;
            btnNavEvents.Enabled = target != panelEvents;
        }
        private async Task LoadMyTicketsAsync()
        {
            //switch grid to show the current user's tickets
            try
            {
                _gridMode = GridMode.Tickets;

                var tickets = await _eventsHttp.GetFromJsonAsync<List<TicketDto>>(
                    $"/api/tickets/{_currentUserId}") ?? new List<TicketDto>();

                var events = await _eventsHttp.GetFromJsonAsync<List<EventView>>("/api/events")
                             ?? new List<EventView>();
                var byId = events.ToDictionary(e => e.Id);

                var rows = tickets.Select(t =>
                {
                    byId.TryGetValue(t.EventId, out var ev);
                    return new TicketView
                    {
                        Id = t.Id,
                        EventId = t.EventId,
                        Event = ev?.Name ?? $"#{t.EventId}",
                        Date = ev?.Date ?? default,
                        Venue = ev?.Venue ?? "",
                        Status = t.Status
                    };
                }).ToList();

                gridEvents.AutoGenerateColumns = true;
                gridEvents.Columns.Clear();
                gridEvents.DataSource = rows;
                if (gridEvents.Rows.Count > 0) gridEvents.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load your tickets: " + ex.Message);
            }
        }
        private async void btnCancelSelected_Click(object sender, EventArgs e)
        {
            // cancel the selected "booked" tickets
            if (_jwt is null) { MessageBox.Show("Login first."); return; }

            if (_gridMode != GridMode.Tickets)
            {
                MessageBox.Show("Switch to 'My Tickets' first.");
                return;
            }

            var selected = gridEvents.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as TicketView)
                .Where(tv => tv is not null)
                .ToList();

            if (selected.Count == 0)
            {
                MessageBox.Show("Select at least one ticket row.");
                return;
            }
            // filter to tickets that are still booked
            var cancellable = selected.Where(tv =>
                string.Equals(tv!.Status, "Booked", StringComparison.OrdinalIgnoreCase)).ToList();

            if (cancellable.Count == 0)
            {
                MessageBox.Show("No selected ticket is in 'Booked' status.");
                return;
            }

            var confirm = MessageBox.Show($"Cancel {cancellable.Count} ticket(s)?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            int ok = 0;
            foreach (var tv in cancellable)
            {
                var res = await _eventsHttp.PostAsJsonAsync($"/api/tickets/{tv!.Id}/cancel", new { });
                if (res.IsSuccessStatusCode) ok++;
            }

            MessageBox.Show($"Cancelled {ok} / {cancellable.Count} ticket(s).");

            // refresh both tickets and events (availability)
            await LoadMyTicketsAsync();
            await LoadEventsAsync();
        }
        private void DoLogout()
        {
            // clear session
            _jwt = null;
            _currentUserId = 0;
            _currentUserName = "";
            _currentRole = "User";
            _eventsHttp.DefaultRequestHeaders.Authorization = null;

            // hide content
            panelMusic.Visible = false;
            panelEvents.Visible = false;

            // clear user-bound inputs
            

            // back to auth menu + hide nav/labels
            ShowEventsView(EventsView.Menu);
            UpdateTopBar();
            BindMusicUser();
        }
        private void btnNavMusic_Click(object sender, EventArgs e)
        {
            ShowOnly(panelMusic);
            BindMusicUser();
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
                // CHANGED: must be logged in to rent ========================================================================================
                if (_jwt == null || _currentUserId <= 0)
                {
                    MessageBox.Show("Please log in to rent albums.", "Not logged in");
                    return;
                }

                // CHANGED: keep the textbox synced & locked to the real user ================================================================
                if (rentalUserID != null)
                {
                    rentalUserID.Text = _currentUserId.ToString();
                    rentalUserID.ReadOnly = true;
                }

                HttpResponseMessage message2 = await _httpClient.GetAsync(
                    $"https://localhost:7245/api/Album/{int.Parse(rentalAlbumID.Text)}");

                if (message2.IsSuccessStatusCode)
                {
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

                    // CHANGED: force logged-in user id (ignore textbox value) ==================================================================
                    var newRental = new
                    {
                        UserId = _currentUserId,   // CHANGED
                        AlbumId = album.ID,
                    };

                    var json = JsonConvert.SerializeObject(newRental);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage message3 = await _httpClient.PostAsync(
                        "https://localhost:7201/api/Rental", content);

                    if (message3.IsSuccessStatusCode)
                    {
                        var json2 = JsonConvert.SerializeObject(album.ID);
                        var content2 = new StringContent(json2, Encoding.UTF8, "application/json");

                        HttpResponseMessage message4 = await _httpClient.PostAsync(
                            $"https://localhost:7245/api/Album/{album.ID}", content2);

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

        private void panelEvents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }


        private void numEventTickets_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuLogin_Click(object sender, EventArgs e)
        {

        }

        private void grpRegister_Enter(object sender, EventArgs e)
        {

        }

        private void grpRegister_Enter_1(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpDashboard_Enter(object sender, EventArgs e)
        {

        }

        private void panelMusic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUserIdNav_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e) => DoLogout();
    }
}