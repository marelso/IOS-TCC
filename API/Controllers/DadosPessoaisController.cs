using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosPessoaisController : ControllerBase
    {
        [HttpGet]
        public ActionResult<DadosPessoaisDTO> Get([FromQuery] string idFuncionario)
        {
            var dados = new DadosPessoaisDTO();

            return Ok(dados);
        }
    }
}
