namespace VibeHive.Client.WinForms.DTO
{
    public class SongRankingView
    {
        public int SongId { get; set; }
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public int Votes { get; set; }
        public int Position { get; set; }
    }
}
