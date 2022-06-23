using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrarPontoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<RegistrarPontoDTO> Get([FromQuery] string idFuncionario)
        {
            var dados = new RegistrarPontoDTO();

            return Ok(dados);
        }
    }
}