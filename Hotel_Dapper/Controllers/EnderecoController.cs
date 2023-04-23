using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<Endereco> Get()
        {
            return new EnderecoService().GetAll();
        }

        [HttpPost(Name = "Insert")]
        public ActionResult Insert(Endereco endereco)
        {
            if (new EnderecoService().Insert(endereco))
                return StatusCode(200);
            else
                return BadRequest();
        }
    }
}
