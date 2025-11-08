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
            btnNavMusic = new Button();
            btnNavEvents = new Button();
            contentPanel = new Panel();
            panelEvents = new Panel();
            btnEventsAction = new Button();
            lblEvents = new Label();
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
            panelMusic.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = SystemColors.MenuHighlight;
            navPanel.Controls.Add(btnNavMusic);
            navPanel.Controls.Add(btnNavEvents);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Margin = new Padding(2);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(959, 60);
            navPanel.TabIndex = 0;
            // 
            // btnNavMusic
            // 
            btnNavMusic.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavMusic.Location = new Point(175, 7);
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
            btnNavEvents.Location = new Point(645, 7);
            btnNavEvents.Margin = new Padding(2);
            btnNavEvents.Name = "btnNavEvents";
            btnNavEvents.Size = new Size(282, 46);
            btnNavEvents.TabIndex = 2;
            btnNavEvents.Text = "Events";
            btnNavEvents.UseVisualStyleBackColor = true;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.InactiveCaption;
            contentPanel.Controls.Add(panelEvents);
            contentPanel.Controls.Add(panelMusic);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 60);
            contentPanel.Margin = new Padding(2);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(11, 10, 11, 10);
            contentPanel.Size = new Size(959, 389);
            contentPanel.TabIndex = 1;
            // 
            // panelEvents
            // 
            panelEvents.BackColor = SystemColors.ControlLightLight;
            panelEvents.Controls.Add(btnEventsAction);
            panelEvents.Controls.Add(lblEvents);
            panelEvents.Dock = DockStyle.Right;
            panelEvents.Location = new Point(494, 10);
            panelEvents.Margin = new Padding(2);
            panelEvents.Name = "panelEvents";
            panelEvents.Size = new Size(454, 369);
            panelEvents.TabIndex = 2;
            panelEvents.Visible = false;
            // 
            // btnEventsAction
            // 
            btnEventsAction.Location = new Point(200, 55);
            btnEventsAction.Margin = new Padding(2);
            btnEventsAction.Name = "btnEventsAction";
            btnEventsAction.Size = new Size(164, 41);
            btnEventsAction.TabIndex = 2;
            btnEventsAction.Text = "Open later…";
            btnEventsAction.UseVisualStyleBackColor = true;
            btnEventsAction.Click += button1_Click;
            // 
            // lblEvents
            // 
            lblEvents.AutoSize = true;
            lblEvents.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEvents.Location = new Point(101, 9);
            lblEvents.Margin = new Padding(2, 0, 2, 0);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(364, 20);
            lblEvents.TabIndex = 2;
            lblEvents.Text = "Events & Tickets (Module 3) — placeholder";
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
            panelMusic.Dock = DockStyle.Left;
            panelMusic.Location = new Point(11, 10);
            panelMusic.Margin = new Padding(2);
            panelMusic.Name = "panelMusic";
            panelMusic.Size = new Size(479, 369);
            panelMusic.TabIndex = 1;
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
            ClientSize = new Size(959, 449);
            Controls.Add(contentPanel);
            Controls.Add(navPanel);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            navPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            panelEvents.ResumeLayout(false);
            panelEvents.PerformLayout();
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
        private Button btnEventsAction;
        private Label lblEvents;
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
    }
}
