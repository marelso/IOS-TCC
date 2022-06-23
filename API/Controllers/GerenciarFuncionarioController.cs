using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenciarFuncionarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<GerenciarFuncionariosDTO> Get([FromQuery] string idFuncionario)
        {
            var dados = new GerenciarFuncionariosDTO();

            return Ok(dados);
        }
    }
}
