using Microsoft.AspNetCore.Mvc;
using PlaylistService.Dtos;
using PlaylistService.Models;

namespace PlaylistService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistsController : ControllerBase
    {
        private static readonly List<Playlist> _playlists = new();
        private static int _nextPlaylistId = 1;
        private static int _nextSongId = 1;

        // POST /api/playlists
        [HttpPost]
        public ActionResult<Playlist> Create(CreatePlaylistDto dto)
        {
            var playlist = new Playlist
            {
                Id = _nextPlaylistId++,
                Name = dto.Name,
                CreatedByUserId = dto.CreatedByUserId,
                IsCollaborative = dto.IsCollaborative
            };

            if (playlist.IsCollaborative)
                playlist.CollaboratorUserIds.Add(dto.CreatedByUserId);

            _playlists.Add(playlist);
            return Created($"/api/playlists/{playlist.Id}", playlist);
        }

        // GET /api/playlists
        [HttpGet]
        public ActionResult<IEnumerable<PlaylistSummaryDto>> GetAll()
        {
            var result = _playlists
                .Select(p => new PlaylistSummaryDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    IsCollaborative = p.IsCollaborative,
                    CreatedByUserId = p.CreatedByUserId,
                    SongCount = p.Songs.Count
                })
                .OrderBy(p => p.Name)
                .ToList();

            return Ok(result);
        }

        // GET /api/playlists/{id}
        [HttpGet("{id:int}")]
        public ActionResult<Playlist> GetOne(int id)
        {
            var playlist = _playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null) return NotFound("Playlist not found.");
            return Ok(playlist);
        }

        // PUT /api/playlists/{id}/add
        [HttpPut("{id:int}/add")]
        public ActionResult AddSongToPlaylist(int id, AddSongDto dto)
        {
            var playlist = _playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null) return NotFound("Playlist not found.");

            var song = new Song
            {
                Id = _nextSongId++,
                Title = dto.Title,
                Artist = dto.Artist,
                Genre = dto.Genre,
                DurationSeconds = dto.DurationSeconds
            };

            playlist.Songs.Add(song);
            return Ok(song);
        }

        // PUT /api/playlists/{id}/invite
        [HttpPut("{id:int}/invite")]
        public ActionResult InviteCollaborator(int id, InviteCollaboratorDto dto)
        {
            var playlist = _playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null) return NotFound("Playlist not found.");
            if (!playlist.IsCollaborative)
                return BadRequest("This playlist is not collaborative.");

            playlist.CollaboratorUserIds.Add(dto.UserId);
            return Ok("Collaborator added.");
        }

        // POST /api/playlists/{id}/vote
        [HttpPost("{id:int}/vote")]
        public ActionResult VoteOnSong(int id, VoteSongDto dto)
        {
            var playlist = _playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null) return NotFound("Playlist not found.");
            if (!playlist.IsCollaborative)
                return BadRequest("Voting only for collaborative playlists.");

            var song = playlist.Songs.FirstOrDefault(s => s.Id == dto.SongId);
            if (song == null) return NotFound("Song not found.");

            song.Votes += dto.Delta;
            return Ok(song);
        }

        // GET /api/playlists/{id}/rankings
        [HttpGet("{id:int}/rankings")]
        public ActionResult<IEnumerable<SongRankingDto>> GetRankings(int id)
        {
            var playlist = _playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null) return NotFound("Playlist not found.");

            var list = playlist.Songs
                .OrderByDescending(s => s.Votes)
                .ThenBy(s => s.Title)
                .Select((s, index) => new SongRankingDto
                {
                    SongId = s.Id,
                    Title = s.Title,
                    Artist = s.Artist,
                    Votes = s.Votes,
                    Position = index + 1
                })
                .ToList();

            return Ok(list);
        }
    }
}
