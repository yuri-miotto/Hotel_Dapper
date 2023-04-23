using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<Cidade> Get()
        {
            return new CidadeService().GetAll();
        }

        [HttpPost(Name = "Insert")]
        public ActionResult Insert(Cidade cidade)
        {
            if (new CidadeService().Insert(cidade))
                return StatusCode(200);
            else
                return BadRequest();
        }
    }
}
