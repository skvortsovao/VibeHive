using System;
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
    }
}