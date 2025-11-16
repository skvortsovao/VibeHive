namespace VibeHive.Client.WinForms.DTO

{
    public class PlaylistView
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public bool IsCollaborative { get; set; }
        public int CreatedByUserId { get; set; }
        public int SongCount { get; set; }
    }
}
