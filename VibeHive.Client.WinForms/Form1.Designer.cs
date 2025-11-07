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
            btnMusicAction = new Button();
            lblMusic = new Label();
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
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(1589, 100);
            navPanel.TabIndex = 0;
            // 
            // btnNavMusic
            // 
            btnNavMusic.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavMusic.Location = new Point(250, 12);
            btnNavMusic.Name = "btnNavMusic";
            btnNavMusic.Size = new Size(403, 76);
            btnNavMusic.TabIndex = 1;
            btnNavMusic.Text = "Music Rentals";
            btnNavMusic.UseVisualStyleBackColor = true;
            // 
            // btnNavEvents
            // 
            btnNavEvents.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavEvents.Location = new Point(922, 12);
            btnNavEvents.Name = "btnNavEvents";
            btnNavEvents.Size = new Size(403, 76);
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
            contentPanel.Location = new Point(0, 100);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(16);
            contentPanel.Size = new Size(1589, 971);
            contentPanel.TabIndex = 1;
            // 
            // panelEvents
            // 
            panelEvents.BackColor = SystemColors.ControlLightLight;
            panelEvents.Controls.Add(btnEventsAction);
            panelEvents.Controls.Add(lblEvents);
            panelEvents.Dock = DockStyle.Right;
            panelEvents.Location = new Point(804, 16);
            panelEvents.Name = "panelEvents";
            panelEvents.Size = new Size(769, 939);
            panelEvents.TabIndex = 2;
            panelEvents.Visible = false;
            // 
            // btnEventsAction
            // 
            btnEventsAction.Location = new Point(286, 91);
            btnEventsAction.Name = "btnEventsAction";
            btnEventsAction.Size = new Size(235, 68);
            btnEventsAction.TabIndex = 2;
            btnEventsAction.Text = "Open later…";
            btnEventsAction.UseVisualStyleBackColor = true;
            btnEventsAction.Click += button1_Click;
            // 
            // lblEvents
            // 
            lblEvents.AutoSize = true;
            lblEvents.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEvents.Location = new Point(144, 15);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(540, 30);
            lblEvents.TabIndex = 2;
            lblEvents.Text = "Events & Tickets (Module 3) — placeholder";
            // 
            // panelMusic
            // 
            panelMusic.BackColor = SystemColors.ControlLightLight;
            panelMusic.Controls.Add(btnMusicAction);
            panelMusic.Controls.Add(lblMusic);
            panelMusic.Dock = DockStyle.Left;
            panelMusic.Location = new Point(16, 16);
            panelMusic.Name = "panelMusic";
            panelMusic.Size = new Size(764, 939);
            panelMusic.TabIndex = 1;
            // 
            // btnMusicAction
            // 
            btnMusicAction.Location = new Point(201, 91);
            btnMusicAction.Name = "btnMusicAction";
            btnMusicAction.Size = new Size(235, 68);
            btnMusicAction.TabIndex = 1;
            btnMusicAction.Text = "Open later…";
            btnMusicAction.UseVisualStyleBackColor = true;
            btnMusicAction.Click += btnMusicAction_Click;
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusic.Location = new Point(81, 15);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(523, 30);
            lblMusic.TabIndex = 0;
            lblMusic.Text = "Music Rentals (Module 1) — placeholder";
            lblMusic.Click += lblMusic_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1589, 1071);
            Controls.Add(contentPanel);
            Controls.Add(navPanel);
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
        private Label lblMusic;
        private Button btnMusicAction;
        private Panel panelEvents;
        private Button btnEventsAction;
        private Label lblEvents;
    }
}
