namespace VibeHive.Client.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            navPanel = new Panel();
            btnNavPlaylists = new Button();
            lblUserIdNav = new Label();
            lblWelcome = new Label();
            btnNavMusic = new Button();
            btnNavEvents = new Button();
            btnLogout = new Button();
            contentPanel = new Panel();
            panelPlaylists = new Panel();
            lstRankings = new ListBox();
            btnShowRankings = new Button();
            btnVoteDown = new Button();
            btnVoteUp = new Button();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            btnAddSong = new Button();
            dgvSongs = new DataGridView();
            btnLoadPlaylists = new Button();
            btnCreatePlaylist = new Button();
            chkCollaborative = new CheckBox();
            txtPlaylistName = new TextBox();
            txtSongDuration = new TextBox();
            txtSongGenre = new TextBox();
            txtSongArtist = new TextBox();
            txtSongTitle = new TextBox();
            dgvPlaylists = new DataGridView();
            panelEvents = new Panel();
            grpDashboard = new GroupBox();
            btnAdminSetCancelled = new Button();
            btnAdminSetBooked = new Button();
            btnAdminAllBookings = new Button();
            btnCancelSelected = new Button();
            lblAvail = new Label();
            numBookQty = new NumericUpDown();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            numEventTickets = new NumericUpDown();
            dtEventDate = new DateTimePicker();
            txtEventGenre = new TextBox();
            txtEventVenue = new TextBox();
            txtEventName = new TextBox();
            btnMyTickets = new Button();
            btnBookTicket = new Button();
            btnCreateEvent = new Button();
            btnLoadEvents = new Button();
            gridEvents = new DataGridView();
            grpLogin = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            btnLoginCancel = new Button();
            btnLoginConfirm = new Button();
            txtLoginPassword = new TextBox();
            txtLoginEmail = new TextBox();
            grpRegister = new GroupBox();
            cmbRegRole = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnRegisterCancel = new Button();
            btnRegisterConfirm = new Button();
            txtRegPassword = new TextBox();
            txtRegEmail = new TextBox();
            txtRegName = new TextBox();
            grpAuthMenu = new GroupBox();
            btnMenuLogin = new Button();
            btnMenuRegister = new Button();
            panelMusic = new Panel();
            deleteAlbumButton = new Button();
            rentalList = new ListBox();
            returnAlbumButton = new Button();
            rentAlbumButton = new Button();
            albumList = new ListBox();
            newAlbumButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label1 = new Label();
            newAlbumYear = new TextBox();
            newAlbumGenre = new TextBox();
            rentalUserID = new TextBox();
            newAlbumArtist = new TextBox();
            returnID = new TextBox();
            rentalAlbumID = new TextBox();
            newAlbumTitle = new TextBox();
            navPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            panelPlaylists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSongs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlaylists).BeginInit();
            panelEvents.SuspendLayout();
            grpDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBookQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEventTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridEvents).BeginInit();
            grpLogin.SuspendLayout();
            grpRegister.SuspendLayout();
            grpAuthMenu.SuspendLayout();
            panelMusic.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = SystemColors.MenuHighlight;
            navPanel.Controls.Add(btnNavPlaylists);
            navPanel.Controls.Add(lblUserIdNav);
            navPanel.Controls.Add(lblWelcome);
            navPanel.Controls.Add(btnNavMusic);
            navPanel.Controls.Add(btnNavEvents);
            navPanel.Controls.Add(btnLogout);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Margin = new Padding(2);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1678, 60);
            navPanel.TabIndex = 0;
            navPanel.Paint += navPanel_Paint;
            // 
            // btnNavPlaylists
            // 
            btnNavPlaylists.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavPlaylists.Location = new Point(1278, 6);
            btnNavPlaylists.Margin = new Padding(2);
            btnNavPlaylists.Name = "btnNavPlaylists";
            btnNavPlaylists.Size = new Size(282, 46);
            btnNavPlaylists.TabIndex = 3;
            btnNavPlaylists.Text = "PLAYLISTS";
            btnNavPlaylists.UseVisualStyleBackColor = true;
            btnNavPlaylists.Click += btnNavPlaylists_Click;
            // 
            // lblUserIdNav
            // 
            lblUserIdNav.AutoSize = true;
            lblUserIdNav.Location = new Point(508, 27);
            lblUserIdNav.Margin = new Padding(2, 0, 2, 0);
            lblUserIdNav.Name = "lblUserIdNav";
            lblUserIdNav.Size = new Size(44, 15);
            lblUserIdNav.TabIndex = 4;
            lblUserIdNav.Text = "label18";
            lblUserIdNav.Visible = false;
            lblUserIdNav.Click += lblUserIdNav_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(502, 7);
            lblWelcome.Margin = new Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(67, 18);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "label18";
            lblWelcome.UseWaitCursor = true;
            lblWelcome.Visible = false;
            // 
            // btnNavMusic
            // 
            btnNavMusic.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavMusic.Location = new Point(208, 7);
            btnNavMusic.Margin = new Padding(2);
            btnNavMusic.Name = "btnNavMusic";
            btnNavMusic.Size = new Size(282, 46);
            btnNavMusic.TabIndex = 1;
            btnNavMusic.Text = "Music Rentals";
            btnNavMusic.UseVisualStyleBackColor = true;
            // 
            // btnNavEvents
            // 
            btnNavEvents.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavEvents.Location = new Point(736, 7);
            btnNavEvents.Margin = new Padding(2);
            btnNavEvents.Name = "btnNavEvents";
            btnNavEvents.Size = new Size(282, 46);
            btnNavEvents.TabIndex = 2;
            btnNavEvents.Text = "Events";
            btnNavEvents.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.RosyBrown;
            btnLogout.Location = new Point(573, 38);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 20);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.InactiveCaption;
            contentPanel.Controls.Add(panelPlaylists);
            contentPanel.Controls.Add(panelEvents);
            contentPanel.Controls.Add(grpLogin);
            contentPanel.Controls.Add(grpRegister);
            contentPanel.Controls.Add(grpAuthMenu);
            contentPanel.Controls.Add(panelMusic);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 60);
            contentPanel.Margin = new Padding(2);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(11, 10, 11, 10);
            contentPanel.Size = new Size(1678, 620);
            contentPanel.TabIndex = 1;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // panelPlaylists
            // 
            panelPlaylists.BackColor = SystemColors.ControlLightLight;
            panelPlaylists.Controls.Add(lstRankings);
            panelPlaylists.Controls.Add(btnShowRankings);
            panelPlaylists.Controls.Add(btnVoteDown);
            panelPlaylists.Controls.Add(btnVoteUp);
            panelPlaylists.Controls.Add(label21);
            panelPlaylists.Controls.Add(label20);
            panelPlaylists.Controls.Add(label19);
            panelPlaylists.Controls.Add(label18);
            panelPlaylists.Controls.Add(btnAddSong);
            panelPlaylists.Controls.Add(dgvSongs);
            panelPlaylists.Controls.Add(btnLoadPlaylists);
            panelPlaylists.Controls.Add(btnCreatePlaylist);
            panelPlaylists.Controls.Add(chkCollaborative);
            panelPlaylists.Controls.Add(txtPlaylistName);
            panelPlaylists.Controls.Add(txtSongDuration);
            panelPlaylists.Controls.Add(txtSongGenre);
            panelPlaylists.Controls.Add(txtSongArtist);
            panelPlaylists.Controls.Add(txtSongTitle);
            panelPlaylists.Controls.Add(dgvPlaylists);
            panelPlaylists.Location = new Point(1209, 99);
            panelPlaylists.Margin = new Padding(2);
            panelPlaylists.Name = "panelPlaylists";
            panelPlaylists.Size = new Size(469, 521);
            panelPlaylists.TabIndex = 3;
            // 
            // lstRankings
            // 
            lstRankings.FormattingEnabled = true;
            lstRankings.ItemHeight = 15;
            lstRankings.Location = new Point(36, 361);
            lstRankings.Name = "lstRankings";
            lstRankings.Size = new Size(399, 109);
            lstRankings.TabIndex = 19;
            // 
            // btnShowRankings
            // 
            btnShowRankings.Location = new Point(239, 485);
            btnShowRankings.Name = "btnShowRankings";
            btnShowRankings.Size = new Size(98, 23);
            btnShowRankings.TabIndex = 17;
            btnShowRankings.Text = "Show Rankings";
            btnShowRankings.UseVisualStyleBackColor = true;
            // 
            // btnVoteDown
            // 
            btnVoteDown.Location = new Point(142, 485);
            btnVoteDown.Name = "btnVoteDown";
            btnVoteDown.Size = new Size(91, 23);
            btnVoteDown.TabIndex = 16;
            btnVoteDown.Text = "Vote Down";
            btnVoteDown.UseVisualStyleBackColor = true;
            // 
            // btnVoteUp
            // 
            btnVoteUp.Location = new Point(34, 485);
            btnVoteUp.Name = "btnVoteUp";
            btnVoteUp.Size = new Size(91, 23);
            btnVoteUp.TabIndex = 15;
            btnVoteUp.Text = "Vote up";
            btnVoteUp.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(382, 285);
            label21.Name = "label21";
            label21.Size = new Size(53, 15);
            label21.TabIndex = 14;
            label21.Text = "Duration";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(277, 285);
            label20.Name = "label20";
            label20.Size = new Size(38, 15);
            label20.TabIndex = 13;
            label20.Text = "Genre";
            label20.Click += label20_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(170, 285);
            label19.Name = "label19";
            label19.Size = new Size(35, 15);
            label19.TabIndex = 12;
            label19.Text = "Artist";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(68, 285);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 11;
            label18.Text = "Title";
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new Point(36, 332);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(91, 23);
            btnAddSong.TabIndex = 10;
            btnAddSong.Text = "Add Song";
            btnAddSong.UseVisualStyleBackColor = true;
            // 
            // dgvSongs
            // 
            dgvSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSongs.Location = new Point(25, 189);
            dgvSongs.Name = "dgvSongs";
            dgvSongs.Size = new Size(429, 88);
            dgvSongs.TabIndex = 9;
            // 
            // btnLoadPlaylists
            // 
            btnLoadPlaylists.Location = new Point(29, 160);
            btnLoadPlaylists.Name = "btnLoadPlaylists";
            btnLoadPlaylists.Size = new Size(91, 23);
            btnLoadPlaylists.TabIndex = 8;
            btnLoadPlaylists.Text = "Load Playlist";
            btnLoadPlaylists.UseVisualStyleBackColor = true;
            btnLoadPlaylists.Click += btnLoadPlaylists_Click;
            // 
            // btnCreatePlaylist
            // 
            btnCreatePlaylist.Location = new Point(237, 127);
            btnCreatePlaylist.Name = "btnCreatePlaylist";
            btnCreatePlaylist.Size = new Size(91, 23);
            btnCreatePlaylist.TabIndex = 7;
            btnCreatePlaylist.Text = "Create Playlist";
            btnCreatePlaylist.UseVisualStyleBackColor = true;
            btnCreatePlaylist.Click += btnCreatePlaylist_Click;
            // 
            // chkCollaborative
            // 
            chkCollaborative.AutoSize = true;
            chkCollaborative.Location = new Point(135, 130);
            chkCollaborative.Name = "chkCollaborative";
            chkCollaborative.Size = new Size(96, 19);
            chkCollaborative.TabIndex = 6;
            chkCollaborative.Text = "Collaborative";
            chkCollaborative.UseVisualStyleBackColor = true;
            // 
            // txtPlaylistName
            // 
            txtPlaylistName.Location = new Point(29, 127);
            txtPlaylistName.Name = "txtPlaylistName";
            txtPlaylistName.Size = new Size(100, 23);
            txtPlaylistName.TabIndex = 5;
            // 
            // txtSongDuration
            // 
            txtSongDuration.Location = new Point(354, 303);
            txtSongDuration.Name = "txtSongDuration";
            txtSongDuration.Size = new Size(100, 23);
            txtSongDuration.TabIndex = 4;
            // 
            // txtSongGenre
            // 
            txtSongGenre.Location = new Point(248, 303);
            txtSongGenre.Name = "txtSongGenre";
            txtSongGenre.Size = new Size(100, 23);
            txtSongGenre.TabIndex = 3;
            // 
            // txtSongArtist
            // 
            txtSongArtist.Location = new Point(142, 303);
            txtSongArtist.Name = "txtSongArtist";
            txtSongArtist.Size = new Size(100, 23);
            txtSongArtist.TabIndex = 2;
            // 
            // txtSongTitle
            // 
            txtSongTitle.Location = new Point(36, 303);
            txtSongTitle.Name = "txtSongTitle";
            txtSongTitle.Size = new Size(100, 23);
            txtSongTitle.TabIndex = 1;
            // 
            // dgvPlaylists
            // 
            dgvPlaylists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlaylists.Location = new Point(25, 22);
            dgvPlaylists.Name = "dgvPlaylists";
            dgvPlaylists.Size = new Size(428, 90);
            dgvPlaylists.TabIndex = 0;
            // 
            // panelEvents
            // 
            panelEvents.BackColor = SystemColors.ControlLightLight;
            panelEvents.Controls.Add(grpDashboard);
            panelEvents.Location = new Point(610, 226);
            panelEvents.Margin = new Padding(2);
            panelEvents.Name = "panelEvents";
            panelEvents.Size = new Size(595, 398);
            panelEvents.TabIndex = 2;
            panelEvents.Visible = false;
            panelEvents.Paint += panelEvents_Paint;
            // 
            // grpDashboard
            // 
            grpDashboard.Controls.Add(btnAdminSetCancelled);
            grpDashboard.Controls.Add(btnAdminSetBooked);
            grpDashboard.Controls.Add(btnAdminAllBookings);
            grpDashboard.Controls.Add(btnCancelSelected);
            grpDashboard.Controls.Add(lblAvail);
            grpDashboard.Controls.Add(numBookQty);
            grpDashboard.Controls.Add(label17);
            grpDashboard.Controls.Add(label16);
            grpDashboard.Controls.Add(label15);
            grpDashboard.Controls.Add(label14);
            grpDashboard.Controls.Add(numEventTickets);
            grpDashboard.Controls.Add(dtEventDate);
            grpDashboard.Controls.Add(txtEventGenre);
            grpDashboard.Controls.Add(txtEventVenue);
            grpDashboard.Controls.Add(txtEventName);
            grpDashboard.Controls.Add(btnMyTickets);
            grpDashboard.Controls.Add(btnBookTicket);
            grpDashboard.Controls.Add(btnCreateEvent);
            grpDashboard.Controls.Add(btnLoadEvents);
            grpDashboard.Controls.Add(gridEvents);
            grpDashboard.Location = new Point(8, 2);
            grpDashboard.Margin = new Padding(2);
            grpDashboard.Name = "grpDashboard";
            grpDashboard.Padding = new Padding(2);
            grpDashboard.Size = new Size(547, 371);
            grpDashboard.TabIndex = 2;
            grpDashboard.TabStop = false;
            grpDashboard.Text = "Dashboard";
            grpDashboard.Visible = false;
            grpDashboard.Enter += grpDashboard_Enter;
            // 
            // btnAdminSetCancelled
            // 
            btnAdminSetCancelled.Location = new Point(351, 310);
            btnAdminSetCancelled.Margin = new Padding(2);
            btnAdminSetCancelled.Name = "btnAdminSetCancelled";
            btnAdminSetCancelled.Size = new Size(94, 20);
            btnAdminSetCancelled.TabIndex = 21;
            btnAdminSetCancelled.Text = "Set Cancelled";
            btnAdminSetCancelled.UseVisualStyleBackColor = true;
            // 
            // btnAdminSetBooked
            // 
            btnAdminSetBooked.Location = new Point(269, 310);
            btnAdminSetBooked.Margin = new Padding(2);
            btnAdminSetBooked.Name = "btnAdminSetBooked";
            btnAdminSetBooked.Size = new Size(78, 20);
            btnAdminSetBooked.TabIndex = 20;
            btnAdminSetBooked.Text = "Set Booked";
            btnAdminSetBooked.UseVisualStyleBackColor = true;
            // 
            // btnAdminAllBookings
            // 
            btnAdminAllBookings.Location = new Point(172, 310);
            btnAdminAllBookings.Margin = new Padding(2);
            btnAdminAllBookings.Name = "btnAdminAllBookings";
            btnAdminAllBookings.Size = new Size(92, 20);
            btnAdminAllBookings.TabIndex = 19;
            btnAdminAllBookings.Text = "All Bookings";
            btnAdminAllBookings.UseVisualStyleBackColor = true;
            // 
            // btnCancelSelected
            // 
            btnCancelSelected.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelSelected.Location = new Point(345, 181);
            btnCancelSelected.Margin = new Padding(2);
            btnCancelSelected.Name = "btnCancelSelected";
            btnCancelSelected.Size = new Size(116, 20);
            btnCancelSelected.TabIndex = 18;
            btnCancelSelected.Text = "Cancel Selected";
            btnCancelSelected.UseVisualStyleBackColor = false;
            // 
            // lblAvail
            // 
            lblAvail.AutoSize = true;
            lblAvail.ForeColor = SystemColors.Highlight;
            lblAvail.Location = new Point(417, 133);
            lblAvail.Margin = new Padding(2, 0, 2, 0);
            lblAvail.Name = "lblAvail";
            lblAvail.Size = new Size(0, 15);
            lblAvail.TabIndex = 17;
            lblAvail.Click += lblAvail_Click;
            // 
            // numBookQty
            // 
            numBookQty.ForeColor = SystemColors.MenuHighlight;
            numBookQty.Location = new Point(417, 159);
            numBookQty.Margin = new Padding(2);
            numBookQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBookQty.Name = "numBookQty";
            numBookQty.Size = new Size(126, 23);
            numBookQty.TabIndex = 16;
            numBookQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 316);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(93, 15);
            label17.TabIndex = 14;
            label17.Text = "Tickets Amount ";
            label17.Click += label17_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 247);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 13;
            label16.Text = "Genre";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 210);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(39, 15);
            label15.TabIndex = 12;
            label15.Text = "Venue";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 173);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(71, 15);
            label14.TabIndex = 11;
            label14.Text = "Event Name";
            label14.Click += label14_Click;
            // 
            // numEventTickets
            // 
            numEventTickets.Location = new Point(105, 312);
            numEventTickets.Margin = new Padding(2);
            numEventTickets.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numEventTickets.Name = "numEventTickets";
            numEventTickets.Size = new Size(40, 23);
            numEventTickets.TabIndex = 10;
            numEventTickets.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numEventTickets.ValueChanged += numEventTickets_ValueChanged;
            // 
            // dtEventDate
            // 
            dtEventDate.Location = new Point(3, 286);
            dtEventDate.Margin = new Padding(2);
            dtEventDate.Name = "dtEventDate";
            dtEventDate.Size = new Size(116, 23);
            dtEventDate.TabIndex = 9;
            // 
            // txtEventGenre
            // 
            txtEventGenre.Location = new Point(3, 264);
            txtEventGenre.Margin = new Padding(2);
            txtEventGenre.Name = "txtEventGenre";
            txtEventGenre.Size = new Size(106, 23);
            txtEventGenre.TabIndex = 8;
            // 
            // txtEventVenue
            // 
            txtEventVenue.Location = new Point(3, 227);
            txtEventVenue.Margin = new Padding(2);
            txtEventVenue.Name = "txtEventVenue";
            txtEventVenue.Size = new Size(106, 23);
            txtEventVenue.TabIndex = 7;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(4, 190);
            txtEventName.Margin = new Padding(2);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(106, 23);
            txtEventName.TabIndex = 6;
            // 
            // btnMyTickets
            // 
            btnMyTickets.Location = new Point(465, 210);
            btnMyTickets.Margin = new Padding(2);
            btnMyTickets.Name = "btnMyTickets";
            btnMyTickets.Size = new Size(78, 20);
            btnMyTickets.TabIndex = 4;
            btnMyTickets.Text = "My Tickets";
            btnMyTickets.UseVisualStyleBackColor = true;
            // 
            // btnBookTicket
            // 
            btnBookTicket.BackColor = SystemColors.MenuHighlight;
            btnBookTicket.Location = new Point(465, 181);
            btnBookTicket.Margin = new Padding(2);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(78, 20);
            btnBookTicket.TabIndex = 3;
            btnBookTicket.Text = "Book Ticket";
            btnBookTicket.UseVisualStyleBackColor = false;
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Location = new Point(4, 339);
            btnCreateEvent.Margin = new Padding(2);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(90, 20);
            btnCreateEvent.TabIndex = 2;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = true;
            // 
            // btnLoadEvents
            // 
            btnLoadEvents.Location = new Point(6, 133);
            btnLoadEvents.Margin = new Padding(2);
            btnLoadEvents.Name = "btnLoadEvents";
            btnLoadEvents.Size = new Size(98, 20);
            btnLoadEvents.TabIndex = 1;
            btnLoadEvents.Text = "Load Events";
            btnLoadEvents.UseVisualStyleBackColor = true;
            // 
            // gridEvents
            // 
            gridEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEvents.Location = new Point(4, 17);
            gridEvents.Margin = new Padding(2);
            gridEvents.Name = "gridEvents";
            gridEvents.RowHeadersWidth = 62;
            gridEvents.Size = new Size(539, 106);
            gridEvents.TabIndex = 0;
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(label13);
            grpLogin.Controls.Add(label12);
            grpLogin.Controls.Add(btnLoginCancel);
            grpLogin.Controls.Add(btnLoginConfirm);
            grpLogin.Controls.Add(txtLoginPassword);
            grpLogin.Controls.Add(txtLoginEmail);
            grpLogin.Location = new Point(610, 118);
            grpLogin.Margin = new Padding(2);
            grpLogin.Name = "grpLogin";
            grpLogin.Padding = new Padding(2);
            grpLogin.Size = new Size(548, 105);
            grpLogin.TabIndex = 2;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(288, 16);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 5;
            label13.Text = "Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(154, 16);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 4;
            label12.Text = "Email";
            // 
            // btnLoginCancel
            // 
            btnLoginCancel.Location = new Point(288, 66);
            btnLoginCancel.Margin = new Padding(2);
            btnLoginCancel.Name = "btnLoginCancel";
            btnLoginCancel.Size = new Size(78, 20);
            btnLoginCancel.TabIndex = 3;
            btnLoginCancel.Text = "Cancel";
            btnLoginCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoginConfirm
            // 
            btnLoginConfirm.Location = new Point(181, 66);
            btnLoginConfirm.Margin = new Padding(2);
            btnLoginConfirm.Name = "btnLoginConfirm";
            btnLoginConfirm.Size = new Size(78, 20);
            btnLoginConfirm.TabIndex = 2;
            btnLoginConfirm.Text = "Login";
            btnLoginConfirm.UseVisualStyleBackColor = true;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(288, 35);
            txtLoginPassword.Margin = new Padding(2);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(106, 23);
            txtLoginPassword.TabIndex = 1;
            txtLoginPassword.TextChanged += txtLoginPassword_TextChanged;
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Location = new Point(154, 36);
            txtLoginEmail.Margin = new Padding(2);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(106, 23);
            txtLoginEmail.TabIndex = 0;
            txtLoginEmail.TextChanged += txtLoginEmail_TextChanged;
            // 
            // grpRegister
            // 
            grpRegister.Controls.Add(cmbRegRole);
            grpRegister.Controls.Add(label11);
            grpRegister.Controls.Add(label10);
            grpRegister.Controls.Add(label9);
            grpRegister.Controls.Add(label8);
            grpRegister.Controls.Add(btnRegisterCancel);
            grpRegister.Controls.Add(btnRegisterConfirm);
            grpRegister.Controls.Add(txtRegPassword);
            grpRegister.Controls.Add(txtRegEmail);
            grpRegister.Controls.Add(txtRegName);
            grpRegister.Location = new Point(11, 121);
            grpRegister.Margin = new Padding(2);
            grpRegister.Name = "grpRegister";
            grpRegister.Padding = new Padding(2);
            grpRegister.Size = new Size(545, 101);
            grpRegister.TabIndex = 1;
            grpRegister.TabStop = false;
            grpRegister.Text = "Register";
            grpRegister.Enter += grpRegister_Enter_1;
            // 
            // cmbRegRole
            // 
            cmbRegRole.FormattingEnabled = true;
            cmbRegRole.Location = new Point(395, 31);
            cmbRegRole.Margin = new Padding(2);
            cmbRegRole.Name = "cmbRegRole";
            cmbRegRole.Size = new Size(129, 23);
            cmbRegRole.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(395, 14);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 9;
            label11.Text = "Role";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(155, 14);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 8;
            label10.Text = "Email";
            label10.Click += label10_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(284, 14);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 7;
            label9.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 14);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 6;
            label8.Text = "Name";
            label8.Click += label8_Click_1;
            // 
            // btnRegisterCancel
            // 
            btnRegisterCancel.Location = new Point(289, 70);
            btnRegisterCancel.Margin = new Padding(2);
            btnRegisterCancel.Name = "btnRegisterCancel";
            btnRegisterCancel.Size = new Size(78, 20);
            btnRegisterCancel.TabIndex = 5;
            btnRegisterCancel.Text = "Cancel";
            btnRegisterCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegisterConfirm
            // 
            btnRegisterConfirm.Location = new Point(182, 70);
            btnRegisterConfirm.Margin = new Padding(2);
            btnRegisterConfirm.Name = "btnRegisterConfirm";
            btnRegisterConfirm.Size = new Size(78, 20);
            btnRegisterConfirm.TabIndex = 4;
            btnRegisterConfirm.Text = "Register";
            btnRegisterConfirm.UseVisualStyleBackColor = true;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(284, 31);
            txtRegPassword.Margin = new Padding(2);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(106, 23);
            txtRegPassword.TabIndex = 3;
            // 
            // txtRegEmail
            // 
            txtRegEmail.Location = new Point(155, 31);
            txtRegEmail.Margin = new Padding(2);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(106, 23);
            txtRegEmail.TabIndex = 1;
            // 
            // txtRegName
            // 
            txtRegName.Location = new Point(46, 31);
            txtRegName.Margin = new Padding(2);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(106, 23);
            txtRegName.TabIndex = 0;
            // 
            // grpAuthMenu
            // 
            grpAuthMenu.Controls.Add(btnMenuLogin);
            grpAuthMenu.Controls.Add(btnMenuRegister);
            grpAuthMenu.Location = new Point(337, 4);
            grpAuthMenu.Margin = new Padding(2);
            grpAuthMenu.Name = "grpAuthMenu";
            grpAuthMenu.Padding = new Padding(2);
            grpAuthMenu.Size = new Size(540, 47);
            grpAuthMenu.TabIndex = 0;
            grpAuthMenu.TabStop = false;
            // 
            // btnMenuLogin
            // 
            btnMenuLogin.Location = new Point(302, 18);
            btnMenuLogin.Margin = new Padding(2);
            btnMenuLogin.Name = "btnMenuLogin";
            btnMenuLogin.Size = new Size(78, 20);
            btnMenuLogin.TabIndex = 1;
            btnMenuLogin.Text = "Login";
            btnMenuLogin.UseVisualStyleBackColor = true;
            btnMenuLogin.Click += btnMenuLogin_Click;
            // 
            // btnMenuRegister
            // 
            btnMenuRegister.Location = new Point(147, 18);
            btnMenuRegister.Margin = new Padding(2);
            btnMenuRegister.Name = "btnMenuRegister";
            btnMenuRegister.Size = new Size(78, 20);
            btnMenuRegister.TabIndex = 0;
            btnMenuRegister.Text = "Register";
            btnMenuRegister.UseVisualStyleBackColor = true;
            // 
            // panelMusic
            // 
            panelMusic.BackColor = SystemColors.ControlLightLight;
            panelMusic.Controls.Add(deleteAlbumButton);
            panelMusic.Controls.Add(rentalList);
            panelMusic.Controls.Add(returnAlbumButton);
            panelMusic.Controls.Add(rentAlbumButton);
            panelMusic.Controls.Add(albumList);
            panelMusic.Controls.Add(newAlbumButton);
            panelMusic.Controls.Add(label4);
            panelMusic.Controls.Add(label3);
            panelMusic.Controls.Add(label2);
            panelMusic.Controls.Add(label6);
            panelMusic.Controls.Add(label7);
            panelMusic.Controls.Add(label5);
            panelMusic.Controls.Add(label1);
            panelMusic.Controls.Add(newAlbumYear);
            panelMusic.Controls.Add(newAlbumGenre);
            panelMusic.Controls.Add(rentalUserID);
            panelMusic.Controls.Add(newAlbumArtist);
            panelMusic.Controls.Add(returnID);
            panelMusic.Controls.Add(rentalAlbumID);
            panelMusic.Controls.Add(newAlbumTitle);
            panelMusic.Location = new Point(11, 226);
            panelMusic.Margin = new Padding(2);
            panelMusic.Name = "panelMusic";
            panelMusic.Size = new Size(595, 398);
            panelMusic.TabIndex = 1;
            panelMusic.Paint += panelMusic_Paint;
            // 
            // deleteAlbumButton
            // 
            deleteAlbumButton.Location = new Point(369, 156);
            deleteAlbumButton.Name = "deleteAlbumButton";
            deleteAlbumButton.Size = new Size(107, 41);
            deleteAlbumButton.TabIndex = 8;
            deleteAlbumButton.Text = "Delete Album from ID";
            deleteAlbumButton.UseVisualStyleBackColor = true;
            deleteAlbumButton.Click += deleteAlbumButton_Click;
            // 
            // rentalList
            // 
            rentalList.FormattingEnabled = true;
            rentalList.ItemHeight = 15;
            rentalList.Location = new Point(3, 203);
            rentalList.Name = "rentalList";
            rentalList.Size = new Size(473, 154);
            rentalList.TabIndex = 7;
            // 
            // returnAlbumButton
            // 
            returnAlbumButton.Location = new Point(274, 174);
            returnAlbumButton.Name = "returnAlbumButton";
            returnAlbumButton.Size = new Size(89, 23);
            returnAlbumButton.TabIndex = 6;
            returnAlbumButton.Text = "Return Album";
            returnAlbumButton.UseVisualStyleBackColor = true;
            returnAlbumButton.Click += returnAlbumButton_Click;
            // 
            // rentAlbumButton
            // 
            rentAlbumButton.Location = new Point(123, 174);
            rentAlbumButton.Name = "rentAlbumButton";
            rentAlbumButton.Size = new Size(82, 23);
            rentAlbumButton.TabIndex = 5;
            rentAlbumButton.Text = "Rent Album";
            rentAlbumButton.UseVisualStyleBackColor = true;
            rentAlbumButton.Click += rentAlbumButton_Click;
            // 
            // albumList
            // 
            albumList.FormattingEnabled = true;
            albumList.ItemHeight = 15;
            albumList.Location = new Point(3, 56);
            albumList.Name = "albumList";
            albumList.Size = new Size(473, 94);
            albumList.TabIndex = 4;
            // 
            // newAlbumButton
            // 
            newAlbumButton.Location = new Point(393, 26);
            newAlbumButton.Name = "newAlbumButton";
            newAlbumButton.Size = new Size(83, 23);
            newAlbumButton.TabIndex = 3;
            newAlbumButton.Text = "Add Album";
            newAlbumButton.UseVisualStyleBackColor = true;
            newAlbumButton.Click += newAlbumButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 9);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 2;
            label4.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 9);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 9);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Artist";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 156);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 2;
            label6.Text = "UserID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 156);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 2;
            label7.Text = "RentalID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 156);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 2;
            label5.Text = "AlbumID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // newAlbumYear
            // 
            newAlbumYear.Location = new Point(320, 27);
            newAlbumYear.Name = "newAlbumYear";
            newAlbumYear.Size = new Size(68, 23);
            newAlbumYear.TabIndex = 1;
            // 
            // newAlbumGenre
            // 
            newAlbumGenre.Location = new Point(246, 27);
            newAlbumGenre.Name = "newAlbumGenre";
            newAlbumGenre.Size = new Size(68, 23);
            newAlbumGenre.TabIndex = 1;
            // 
            // rentalUserID
            // 
            rentalUserID.Location = new Point(63, 174);
            rentalUserID.Name = "rentalUserID";
            rentalUserID.Size = new Size(54, 23);
            rentalUserID.TabIndex = 1;
            // 
            // newAlbumArtist
            // 
            newAlbumArtist.Location = new Point(122, 27);
            newAlbumArtist.Name = "newAlbumArtist";
            newAlbumArtist.Size = new Size(118, 23);
            newAlbumArtist.TabIndex = 1;
            // 
            // returnID
            // 
            returnID.Location = new Point(211, 174);
            returnID.Name = "returnID";
            returnID.Size = new Size(54, 23);
            returnID.TabIndex = 1;
            // 
            // rentalAlbumID
            // 
            rentalAlbumID.Location = new Point(3, 174);
            rentalAlbumID.Name = "rentalAlbumID";
            rentalAlbumID.Size = new Size(54, 23);
            rentalAlbumID.TabIndex = 1;
            // 
            // newAlbumTitle
            // 
            newAlbumTitle.Location = new Point(3, 27);
            newAlbumTitle.Name = "newAlbumTitle";
            newAlbumTitle.Size = new Size(113, 23);
            newAlbumTitle.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 680);
            Controls.Add(contentPanel);
            Controls.Add(navPanel);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            panelPlaylists.ResumeLayout(false);
            panelPlaylists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSongs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlaylists).EndInit();
            panelEvents.ResumeLayout(false);
            grpDashboard.ResumeLayout(false);
            grpDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBookQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEventTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridEvents).EndInit();
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            grpRegister.ResumeLayout(false);
            grpRegister.PerformLayout();
            grpAuthMenu.ResumeLayout(false);
            panelMusic.ResumeLayout(false);
            panelMusic.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Button btnNavMusic;
        private Button btnNavEvents;
        private Panel contentPanel;
        private Panel panelMusic;
        private Panel panelEvents;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox newAlbumYear;
        private TextBox newAlbumGenre;
        private TextBox newAlbumArtist;
        private TextBox newAlbumTitle;
        private Button newAlbumButton;
        private ListBox albumList;
        private Label label5;
        private TextBox rentalAlbumID;
        private Label label6;
        private TextBox rentalUserID;
        private Button rentAlbumButton;
        private ListBox rentalList;
        private Button returnAlbumButton;
        private Label label7;
        private TextBox returnID;
        private Button deleteAlbumButton;
        private GroupBox grpRegister;
        private GroupBox grpAuthMenu;
        private Button btnMenuLogin;
        private Button btnMenuRegister;
        private GroupBox grpLogin;
        private Button btnLoginCancel;
        private Button btnLoginConfirm;
        private TextBox txtLoginPassword;
        private TextBox txtLoginEmail;
        private Button btnRegisterCancel;
        private Button btnRegisterConfirm;
        private TextBox txtRegPassword;
        private TextBox txtRegEmail;
        private TextBox txtRegName;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label13;
        private Label label12;
        private GroupBox grpDashboard;
        private Button btnLogout;
        private Button btnMyTickets;
        private Button btnBookTicket;
        private Button btnCreateEvent;
        private Button btnLoadEvents;
        private DataGridView gridEvents;
        private TextBox txtEventGenre;
        private TextBox txtEventVenue;
        private TextBox txtEventName;
        private NumericUpDown numEventTickets;
        private DateTimePicker dtEventDate;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private NumericUpDown numBookQty;
        private Label lblAvail;
        private Button btnCancelSelected;
        private ComboBox cmbRegRole;
        private Button btnAdminSetCancelled;
        private Button btnAdminSetBooked;
        private Button btnAdminAllBookings;
        private Label lblUserIdNav;
        private Label lblWelcome;
        private Button btnNavPlaylists;
        private Panel panelPlaylists;
        private TextBox txtSongDuration;
        private TextBox txtSongGenre;
        private TextBox txtSongArtist;
        private TextBox txtSongTitle;
        private DataGridView dgvPlaylists;
        private DataGridView dgvSongs;
        private Button btnLoadPlaylists;
        private Button btnCreatePlaylist;
        private CheckBox chkCollaborative;
        private TextBox txtPlaylistName;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Button btnAddSong;
        private Button btnShowRankings;
        private Button btnVoteDown;
        private Button btnVoteUp;
        private ListBox lstRankings;
    }
}
