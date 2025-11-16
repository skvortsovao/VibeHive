namespace PlaylistService.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public string Genre { get; set; } = "";
        public int DurationSeconds { get; set; }
        public int Votes { get; set; } = 0;
    }

    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int CreatedByUserId { get; set; }
        public bool IsCollaborative { get; set; }

        public List<Song> Songs { get; set; } = new();
        public HashSet<int> CollaboratorUserIds { get; set; } = new();
    }
}
