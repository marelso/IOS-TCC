using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardGestorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<DashboardGestorDTO> Get([FromQuery] string idFuncionario)
        {
            var dados = new DashboardGestorDTO();

            return Ok(dados);
        }
    }
}
