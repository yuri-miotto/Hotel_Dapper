using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassagemController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<Passagem> Get()
        {
            return new PassagemService().GetAll();
        }

        [HttpPost(Name = "Insert")]
        public ActionResult Insert(Passagem passagem)
        {
            if (new PassagemService().Insert(passagem))
                return StatusCode(200);
            else
                return BadRequest();
        }
    }
}
