using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaRegistrosParticularesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ListaRegistrosParticularesDTO> Get()
        {
            var dados = new ListaRegistrosParticularesDTO();

            return Ok(dados);
        }
    }
}
