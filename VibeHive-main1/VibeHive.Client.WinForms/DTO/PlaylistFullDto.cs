using System.Collections.Generic;
using VibeHive.Client.WinForms.DTO;

namespace VibeHive.Client.WinForms.DTO
{
    public class PlaylistFullDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int CreatedByUserId { get; set; }
        public bool IsCollaborative { get; set; }
        public List<PlaylistSongView> Songs { get; set; } = new();
    }
}
