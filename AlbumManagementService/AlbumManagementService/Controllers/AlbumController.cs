using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace AlbumManagementService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : Controller
    {
        private static List<Album> AlbumList = new List<Album>();
        //get all
        [HttpGet]
        public ActionResult<List<Album>> GetAlbums()
        {
            try
            {
                return Ok(AlbumList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //add
        [HttpPost]
        public ActionResult AddAlbum(Album addedAlbum)
        {
            try
            {
                if (AlbumList.Count > 0)
                {
                    addedAlbum.ID = AlbumList.Max(u => u.ID) + 1;
                }
                AlbumList.Add(addedAlbum);
                return Ok("Album added.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //delete
        [HttpDelete("{deletedID}")]
        public ActionResult DeleteAlbum(int deletedID)
        {
            try
            {
                var album = AlbumList.FirstOrDefault(x => x.ID == deletedID);
                if (album == null)
                {
                    return NotFound("Thats not a real album.");
                }
                AlbumList.Remove(album);
                return Ok("Retconned album existence.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //get a id
        [HttpGet("{wantedID}")]
        public ActionResult GetAlbum(int wantedID)
        {
            try
            {
                var movie = AlbumList.FirstOrDefault(x => x.ID == wantedID);
                if (movie == null)
                {
                    return NotFound("Thats not a real album.");
                }
                return Ok(movie);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("{wantedID}")]
        public ActionResult AlbumAvailability(int wantedID)
        {
            try
            {
                var movie = AlbumList.FirstOrDefault(b => b.ID == wantedID);
                if (movie == null)
                {
                    return NotFound("Album not found!");
                }
                movie.Available = !movie.Available;
                return Ok("Album availability change successful.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
