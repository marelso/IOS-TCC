using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AjustarJornadaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<AjustarJornadaDTO> Get([FromQuery] string idFuncionario)
        {
            var dados = new AjustarJornadaDTO();

            return Ok(dados);
        }
    }
}
