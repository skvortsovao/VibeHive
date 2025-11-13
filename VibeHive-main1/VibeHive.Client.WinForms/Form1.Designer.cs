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
            lblUserIdNav = new Label();
            lblWelcome = new Label();
            btnNavMusic = new Button();
            btnNavEvents = new Button();
            btnLogout = new Button();
            contentPanel = new Panel();
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
            navPanel.Controls.Add(lblUserIdNav);
            navPanel.Controls.Add(lblWelcome);
            navPanel.Controls.Add(btnNavMusic);
            navPanel.Controls.Add(btnNavEvents);
            navPanel.Controls.Add(btnLogout);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1708, 100);
            navPanel.TabIndex = 0;
            navPanel.Paint += navPanel_Paint;
            // 
            // lblUserIdNav
            // 
            lblUserIdNav.AutoSize = true;
            lblUserIdNav.Location = new Point(725, 45);
            lblUserIdNav.Name = "lblUserIdNav";
            lblUserIdNav.Size = new Size(69, 25);
            lblUserIdNav.TabIndex = 4;
            lblUserIdNav.Text = "label18";
            lblUserIdNav.Visible = false;
            lblUserIdNav.Click += lblUserIdNav_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(717, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(98, 28);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "label18";
            lblWelcome.UseWaitCursor = true;
            lblWelcome.Visible = false;
            // 
            // btnNavMusic
            // 
            btnNavMusic.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavMusic.Location = new Point(297, 12);
            btnNavMusic.Name = "btnNavMusic";
            btnNavMusic.Size = new Size(403, 77);
            btnNavMusic.TabIndex = 1;
            btnNavMusic.Text = "Music Rentals";
            btnNavMusic.UseVisualStyleBackColor = true;
            // 
            // btnNavEvents
            // 
            btnNavEvents.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavEvents.Location = new Point(1051, 12);
            btnNavEvents.Name = "btnNavEvents";
            btnNavEvents.Size = new Size(403, 77);
            btnNavEvents.TabIndex = 2;
            btnNavEvents.Text = "Events";
            btnNavEvents.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.RosyBrown;
            btnLogout.Location = new Point(819, 63);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.InactiveCaption;
            contentPanel.Controls.Add(panelEvents);
            contentPanel.Controls.Add(grpLogin);
            contentPanel.Controls.Add(grpRegister);
            contentPanel.Controls.Add(grpAuthMenu);
            contentPanel.Controls.Add(panelMusic);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 100);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(16, 17, 16, 17);
            contentPanel.Size = new Size(1708, 1058);
            contentPanel.TabIndex = 1;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // panelEvents
            // 
            panelEvents.BackColor = SystemColors.ControlLightLight;
            panelEvents.Controls.Add(grpDashboard);
            panelEvents.Location = new Point(872, 377);
            panelEvents.Name = "panelEvents";
            panelEvents.Size = new Size(850, 664);
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
            grpDashboard.Location = new Point(12, 3);
            grpDashboard.Name = "grpDashboard";
            grpDashboard.Size = new Size(782, 618);
            grpDashboard.TabIndex = 2;
            grpDashboard.TabStop = false;
            grpDashboard.Text = "Dashboard";
            grpDashboard.Visible = false;
            grpDashboard.Enter += grpDashboard_Enter;
            // 
            // btnAdminSetCancelled
            // 
            btnAdminSetCancelled.Location = new Point(502, 517);
            btnAdminSetCancelled.Name = "btnAdminSetCancelled";
            btnAdminSetCancelled.Size = new Size(134, 34);
            btnAdminSetCancelled.TabIndex = 21;
            btnAdminSetCancelled.Text = "Set Cancelled";
            btnAdminSetCancelled.UseVisualStyleBackColor = true;
            // 
            // btnAdminSetBooked
            // 
            btnAdminSetBooked.Location = new Point(384, 517);
            btnAdminSetBooked.Name = "btnAdminSetBooked";
            btnAdminSetBooked.Size = new Size(112, 34);
            btnAdminSetBooked.TabIndex = 20;
            btnAdminSetBooked.Text = "Set Booked";
            btnAdminSetBooked.UseVisualStyleBackColor = true;
            // 
            // btnAdminAllBookings
            // 
            btnAdminAllBookings.Location = new Point(246, 517);
            btnAdminAllBookings.Name = "btnAdminAllBookings";
            btnAdminAllBookings.Size = new Size(132, 34);
            btnAdminAllBookings.TabIndex = 19;
            btnAdminAllBookings.Text = "All Bookings";
            btnAdminAllBookings.UseVisualStyleBackColor = true;
            // 
            // btnCancelSelected
            // 
            btnCancelSelected.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelSelected.Location = new Point(493, 302);
            btnCancelSelected.Name = "btnCancelSelected";
            btnCancelSelected.Size = new Size(165, 34);
            btnCancelSelected.TabIndex = 18;
            btnCancelSelected.Text = "Cancel Selected";
            btnCancelSelected.UseVisualStyleBackColor = false;
            // 
            // lblAvail
            // 
            lblAvail.AutoSize = true;
            lblAvail.ForeColor = SystemColors.Highlight;
            lblAvail.Location = new Point(596, 222);
            lblAvail.Name = "lblAvail";
            lblAvail.Size = new Size(0, 25);
            lblAvail.TabIndex = 17;
            lblAvail.Click += lblAvail_Click;
            // 
            // numBookQty
            // 
            numBookQty.ForeColor = SystemColors.MenuHighlight;
            numBookQty.Location = new Point(596, 265);
            numBookQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBookQty.Name = "numBookQty";
            numBookQty.Size = new Size(180, 31);
            numBookQty.TabIndex = 16;
            numBookQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(4, 526);
            label17.Name = "label17";
            label17.Size = new Size(140, 25);
            label17.TabIndex = 14;
            label17.Text = "Tickets Amount ";
            label17.Click += label17_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(4, 412);
            label16.Name = "label16";
            label16.Size = new Size(58, 25);
            label16.TabIndex = 13;
            label16.Text = "Genre";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 350);
            label15.Name = "label15";
            label15.Size = new Size(60, 25);
            label15.TabIndex = 12;
            label15.Text = "Venue";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 288);
            label14.Name = "label14";
            label14.Size = new Size(107, 25);
            label14.TabIndex = 11;
            label14.Text = "Event Name";
            label14.Click += label14_Click;
            // 
            // numEventTickets
            // 
            numEventTickets.Location = new Point(150, 520);
            numEventTickets.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numEventTickets.Name = "numEventTickets";
            numEventTickets.Size = new Size(57, 31);
            numEventTickets.TabIndex = 10;
            numEventTickets.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numEventTickets.ValueChanged += numEventTickets_ValueChanged;
            // 
            // dtEventDate
            // 
            dtEventDate.Location = new Point(4, 477);
            dtEventDate.Name = "dtEventDate";
            dtEventDate.Size = new Size(164, 31);
            dtEventDate.TabIndex = 9;
            // 
            // txtEventGenre
            // 
            txtEventGenre.Location = new Point(4, 440);
            txtEventGenre.Name = "txtEventGenre";
            txtEventGenre.Size = new Size(150, 31);
            txtEventGenre.TabIndex = 8;
            // 
            // txtEventVenue
            // 
            txtEventVenue.Location = new Point(4, 378);
            txtEventVenue.Name = "txtEventVenue";
            txtEventVenue.Size = new Size(150, 31);
            txtEventVenue.TabIndex = 7;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(6, 316);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(150, 31);
            txtEventName.TabIndex = 6;
            // 
            // btnMyTickets
            // 
            btnMyTickets.Location = new Point(664, 350);
            btnMyTickets.Name = "btnMyTickets";
            btnMyTickets.Size = new Size(112, 34);
            btnMyTickets.TabIndex = 4;
            btnMyTickets.Text = "My Tickets";
            btnMyTickets.UseVisualStyleBackColor = true;
            // 
            // btnBookTicket
            // 
            btnBookTicket.BackColor = SystemColors.MenuHighlight;
            btnBookTicket.Location = new Point(664, 302);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(112, 34);
            btnBookTicket.TabIndex = 3;
            btnBookTicket.Text = "Book Ticket";
            btnBookTicket.UseVisualStyleBackColor = false;
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Location = new Point(6, 565);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(128, 34);
            btnCreateEvent.TabIndex = 2;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = true;
            // 
            // btnLoadEvents
            // 
            btnLoadEvents.Location = new Point(8, 222);
            btnLoadEvents.Name = "btnLoadEvents";
            btnLoadEvents.Size = new Size(140, 34);
            btnLoadEvents.TabIndex = 1;
            btnLoadEvents.Text = "Load Events";
            btnLoadEvents.UseVisualStyleBackColor = true;
            // 
            // gridEvents
            // 
            gridEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEvents.Location = new Point(6, 28);
            gridEvents.Name = "gridEvents";
            gridEvents.RowHeadersWidth = 62;
            gridEvents.Size = new Size(770, 177);
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
            grpLogin.Location = new Point(872, 196);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(783, 175);
            grpLogin.TabIndex = 2;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(411, 27);
            label13.Name = "label13";
            label13.Size = new Size(87, 25);
            label13.TabIndex = 5;
            label13.Text = "Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(220, 27);
            label12.Name = "label12";
            label12.Size = new Size(54, 25);
            label12.TabIndex = 4;
            label12.Text = "Email";
            // 
            // btnLoginCancel
            // 
            btnLoginCancel.Location = new Point(411, 110);
            btnLoginCancel.Name = "btnLoginCancel";
            btnLoginCancel.Size = new Size(112, 34);
            btnLoginCancel.TabIndex = 3;
            btnLoginCancel.Text = "Cancel";
            btnLoginCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoginConfirm
            // 
            btnLoginConfirm.Location = new Point(258, 110);
            btnLoginConfirm.Name = "btnLoginConfirm";
            btnLoginConfirm.Size = new Size(112, 34);
            btnLoginConfirm.TabIndex = 2;
            btnLoginConfirm.Text = "Login";
            btnLoginConfirm.UseVisualStyleBackColor = true;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(411, 59);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(150, 31);
            txtLoginPassword.TabIndex = 1;
            txtLoginPassword.TextChanged += txtLoginPassword_TextChanged;
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Location = new Point(220, 60);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(150, 31);
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
            grpRegister.Location = new Point(16, 202);
            grpRegister.Name = "grpRegister";
            grpRegister.Size = new Size(778, 169);
            grpRegister.TabIndex = 1;
            grpRegister.TabStop = false;
            grpRegister.Text = "Register";
            grpRegister.Enter += grpRegister_Enter_1;
            // 
            // cmbRegRole
            // 
            cmbRegRole.FormattingEnabled = true;
            cmbRegRole.Location = new Point(564, 51);
            cmbRegRole.Name = "cmbRegRole";
            cmbRegRole.Size = new Size(182, 33);
            cmbRegRole.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(564, 23);
            label11.Name = "label11";
            label11.Size = new Size(46, 25);
            label11.TabIndex = 9;
            label11.Text = "Role";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(222, 23);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 8;
            label10.Text = "Email";
            label10.Click += label10_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(406, 23);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 7;
            label9.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 23);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 6;
            label8.Text = "Name";
            label8.Click += label8_Click_1;
            // 
            // btnRegisterCancel
            // 
            btnRegisterCancel.Location = new Point(413, 116);
            btnRegisterCancel.Name = "btnRegisterCancel";
            btnRegisterCancel.Size = new Size(112, 34);
            btnRegisterCancel.TabIndex = 5;
            btnRegisterCancel.Text = "Cancel";
            btnRegisterCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegisterConfirm
            // 
            btnRegisterConfirm.Location = new Point(260, 116);
            btnRegisterConfirm.Name = "btnRegisterConfirm";
            btnRegisterConfirm.Size = new Size(112, 34);
            btnRegisterConfirm.TabIndex = 4;
            btnRegisterConfirm.Text = "Register";
            btnRegisterConfirm.UseVisualStyleBackColor = true;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(406, 51);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(150, 31);
            txtRegPassword.TabIndex = 3;
            // 
            // txtRegEmail
            // 
            txtRegEmail.Location = new Point(222, 51);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(150, 31);
            txtRegEmail.TabIndex = 1;
            // 
            // txtRegName
            // 
            txtRegName.Location = new Point(66, 51);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(150, 31);
            txtRegName.TabIndex = 0;
            // 
            // grpAuthMenu
            // 
            grpAuthMenu.Controls.Add(btnMenuLogin);
            grpAuthMenu.Controls.Add(btnMenuRegister);
            grpAuthMenu.Location = new Point(482, 6);
            grpAuthMenu.Name = "grpAuthMenu";
            grpAuthMenu.Size = new Size(772, 78);
            grpAuthMenu.TabIndex = 0;
            grpAuthMenu.TabStop = false;
            // 
            // btnMenuLogin
            // 
            btnMenuLogin.Location = new Point(432, 30);
            btnMenuLogin.Name = "btnMenuLogin";
            btnMenuLogin.Size = new Size(112, 34);
            btnMenuLogin.TabIndex = 1;
            btnMenuLogin.Text = "Login";
            btnMenuLogin.UseVisualStyleBackColor = true;
            btnMenuLogin.Click += btnMenuLogin_Click;
            // 
            // btnMenuRegister
            // 
            btnMenuRegister.Location = new Point(210, 30);
            btnMenuRegister.Name = "btnMenuRegister";
            btnMenuRegister.Size = new Size(112, 34);
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
            panelMusic.Location = new Point(16, 377);
            panelMusic.Name = "panelMusic";
            panelMusic.Size = new Size(850, 664);
            panelMusic.TabIndex = 1;
            panelMusic.Paint += panelMusic_Paint;
            // 
            // deleteAlbumButton
            // 
            deleteAlbumButton.Location = new Point(527, 260);
            deleteAlbumButton.Margin = new Padding(4, 5, 4, 5);
            deleteAlbumButton.Name = "deleteAlbumButton";
            deleteAlbumButton.Size = new Size(153, 68);
            deleteAlbumButton.TabIndex = 8;
            deleteAlbumButton.Text = "Delete Album from ID";
            deleteAlbumButton.UseVisualStyleBackColor = true;
            deleteAlbumButton.Click += deleteAlbumButton_Click;
            // 
            // rentalList
            // 
            rentalList.FormattingEnabled = true;
            rentalList.ItemHeight = 25;
            rentalList.Location = new Point(4, 338);
            rentalList.Margin = new Padding(4, 5, 4, 5);
            rentalList.Name = "rentalList";
            rentalList.Size = new Size(674, 254);
            rentalList.TabIndex = 7;
            // 
            // returnAlbumButton
            // 
            returnAlbumButton.Location = new Point(391, 290);
            returnAlbumButton.Margin = new Padding(4, 5, 4, 5);
            returnAlbumButton.Name = "returnAlbumButton";
            returnAlbumButton.Size = new Size(127, 38);
            returnAlbumButton.TabIndex = 6;
            returnAlbumButton.Text = "Return Album";
            returnAlbumButton.UseVisualStyleBackColor = true;
            returnAlbumButton.Click += returnAlbumButton_Click;
            // 
            // rentAlbumButton
            // 
            rentAlbumButton.Location = new Point(176, 290);
            rentAlbumButton.Margin = new Padding(4, 5, 4, 5);
            rentAlbumButton.Name = "rentAlbumButton";
            rentAlbumButton.Size = new Size(117, 38);
            rentAlbumButton.TabIndex = 5;
            rentAlbumButton.Text = "Rent Album";
            rentAlbumButton.UseVisualStyleBackColor = true;
            rentAlbumButton.Click += rentAlbumButton_Click;
            // 
            // albumList
            // 
            albumList.FormattingEnabled = true;
            albumList.ItemHeight = 25;
            albumList.Location = new Point(4, 93);
            albumList.Margin = new Padding(4, 5, 4, 5);
            albumList.Name = "albumList";
            albumList.Size = new Size(674, 154);
            albumList.TabIndex = 4;
            // 
            // newAlbumButton
            // 
            newAlbumButton.Location = new Point(561, 43);
            newAlbumButton.Margin = new Padding(4, 5, 4, 5);
            newAlbumButton.Name = "newAlbumButton";
            newAlbumButton.Size = new Size(119, 38);
            newAlbumButton.TabIndex = 3;
            newAlbumButton.Text = "Add Album";
            newAlbumButton.UseVisualStyleBackColor = true;
            newAlbumButton.Click += newAlbumButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 2;
            label4.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Artist";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 260);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 2;
            label6.Text = "UserID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(301, 260);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 2;
            label7.Text = "RentalID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 260);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 2;
            label5.Text = "AlbumID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // newAlbumYear
            // 
            newAlbumYear.Location = new Point(457, 45);
            newAlbumYear.Margin = new Padding(4, 5, 4, 5);
            newAlbumYear.Name = "newAlbumYear";
            newAlbumYear.Size = new Size(95, 31);
            newAlbumYear.TabIndex = 1;
            // 
            // newAlbumGenre
            // 
            newAlbumGenre.Location = new Point(351, 45);
            newAlbumGenre.Margin = new Padding(4, 5, 4, 5);
            newAlbumGenre.Name = "newAlbumGenre";
            newAlbumGenre.Size = new Size(95, 31);
            newAlbumGenre.TabIndex = 1;
            // 
            // rentalUserID
            // 
            rentalUserID.Location = new Point(90, 290);
            rentalUserID.Margin = new Padding(4, 5, 4, 5);
            rentalUserID.Name = "rentalUserID";
            rentalUserID.Size = new Size(75, 31);
            rentalUserID.TabIndex = 1;
            // 
            // newAlbumArtist
            // 
            newAlbumArtist.Location = new Point(174, 45);
            newAlbumArtist.Margin = new Padding(4, 5, 4, 5);
            newAlbumArtist.Name = "newAlbumArtist";
            newAlbumArtist.Size = new Size(167, 31);
            newAlbumArtist.TabIndex = 1;
            // 
            // returnID
            // 
            returnID.Location = new Point(301, 290);
            returnID.Margin = new Padding(4, 5, 4, 5);
            returnID.Name = "returnID";
            returnID.Size = new Size(75, 31);
            returnID.TabIndex = 1;
            // 
            // rentalAlbumID
            // 
            rentalAlbumID.Location = new Point(4, 290);
            rentalAlbumID.Margin = new Padding(4, 5, 4, 5);
            rentalAlbumID.Name = "rentalAlbumID";
            rentalAlbumID.Size = new Size(75, 31);
            rentalAlbumID.TabIndex = 1;
            // 
            // newAlbumTitle
            // 
            newAlbumTitle.Location = new Point(4, 45);
            newAlbumTitle.Margin = new Padding(4, 5, 4, 5);
            newAlbumTitle.Name = "newAlbumTitle";
            newAlbumTitle.Size = new Size(160, 31);
            newAlbumTitle.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1708, 1158);
            Controls.Add(contentPanel);
            Controls.Add(navPanel);
            Name = "Form1";
            Text = "Form1";
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
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
    }
}
