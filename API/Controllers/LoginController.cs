using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get([FromQuery] string login, string senha)
        {
            var response = string.Empty;
            var movimento = new Movimento();
            var query = string.Format($"SELECT ID FROM Logins WHERE Login = '{login}' AND Senha = '{senha}'");
            var data = movimento.ConsultaQuery(query);

            if (data == null || data.Rows.Count == 0)
                return BadRequest();
            else
            {
                var idFuncionario = data.Rows[0][0].ToString();
                return Ok(idFuncionario);
            }
        }
    }
}
