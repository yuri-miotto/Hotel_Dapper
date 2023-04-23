using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacoteController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<Pacote> Get()
        {
            return new PacoteService().GetAll();
        }

        [HttpPost(Name = "Insert")]
        public ActionResult Insert(Pacote pacote)
        {
            if (new PacoteService().Insert(pacote))
                return StatusCode(200);
            else
                return BadRequest();
        }
    }
}
