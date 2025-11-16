namespace PlaylistService.Dtos
{
    public class CreatePlaylistDto
    {
        public string Name { get; set; } = "";
        public int CreatedByUserId { get; set; }
        public bool IsCollaborative { get; set; }
    }

    public class PlaylistSummaryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public bool IsCollaborative { get; set; }
        public int CreatedByUserId { get; set; }
        public int SongCount { get; set; }
    }

    public class AddSongDto
    {
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public string Genre { get; set; } = "";
        public int DurationSeconds { get; set; }
    }

    public class InviteCollaboratorDto
    {
        public int UserId { get; set; }
    }

    public class VoteSongDto
    {
        public int SongId { get; set; }
        public int UserId { get; set; }
        public int Delta { get; set; } = 1;  // +1 or -1
    }

    public class SongRankingDto
    {
        public int SongId { get; set; }
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public int Votes { get; set; }
        public int Position { get; set; }
    }
}
