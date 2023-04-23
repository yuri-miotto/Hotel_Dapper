using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<Cliente> Get()
        {
            return new ClienteService().GetAll();
        }

        [HttpPost(Name = "Insert")]
        public ActionResult Insert(Cliente cliente)
        {
            if (new ClienteService().Insert(cliente))
                return StatusCode(200);
            else
                return BadRequest();
        }
    }
}
