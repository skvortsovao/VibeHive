namespace VibeHive.Client.WinForms.DTO
{
    public class PlaylistSongView
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public string Genre { get; set; } = "";
        public int DurationSeconds { get; set; }
        public int Votes { get; set; }
    }
}
