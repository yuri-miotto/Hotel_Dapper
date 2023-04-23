using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<Hotel> Get()
        {
            return new HotelService().GetAll();
        }

        [HttpPost(Name = "Insert")]
        public ActionResult Insert(Hotel hotel)
        {
            if (new HotelService().Insert(hotel))
                return StatusCode(200);
            else
                return BadRequest();
        }
    }
}
