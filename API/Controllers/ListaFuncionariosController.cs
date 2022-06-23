using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaFuncionariosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ListaFuncionariosDTO> Get()
        {
            var dados = new ListaFuncionariosDTO();

            return Ok(dados);
        }
    }
}
