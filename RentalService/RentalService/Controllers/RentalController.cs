using Microsoft.AspNetCore.Mvc;

namespace RentalService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalController : Controller
    {
        private static List<Rental> RentalList = new List<Rental>();

        [HttpPost]
        public ActionResult RentAlbum(Rental rental)
        {
            try
            {
                rental.RentalTime = DateTime.Now;
                rental.ReturnDate = null;
                if (RentalList.Count > 0)
                {
                    rental.ID = RentalList.Max(u => u.ID) + 1;
                }
                RentalList.Add(rental);
                return Ok("Album rent successful.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("{rentID}/return")]
        public ActionResult ReturnAlbum(int rentID)
        {
            try
            {
                var rent = RentalList.FirstOrDefault(b => b.ID == rentID);
                if (rent == null)
                {
                    return NotFound("Album not found!");
                }
                if (rent.ReturnDate != null)
                {
                    return BadRequest("Album already returned.");
                }
                rent.ReturnDate = DateTime.Now;
                return Ok("Album return successful.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<Rental>> getAllRentals()
        {
            try
            {
                return Ok(RentalList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //we need the rental's movie id for something
        [HttpGet("{wantedID}")]
        public ActionResult GetRental(int wantedID)
        {
            try
            {
                var rental = RentalList.FirstOrDefault(x => x.ID == wantedID);
                if (rental == null)
                {
                    return NotFound("Thats not a real rental.");
                }
                return Ok(rental);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
