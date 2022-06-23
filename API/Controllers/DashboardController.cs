using API.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        [HttpGet]
        public ActionResult<DashboardDTO> Get([FromQuery] string idFuncionario)
        {
            var movimento = new Movimento();
            var query = string.Format($"SELECT CH, IDHorario FROM Funcionarios WHERE ID = {idFuncionario}");
            var data = movimento.ConsultaQuery(query);

            if (data == null || data.Rows.Count == 0)
                return BadRequest();
            else
            {
                var CargaSemanal = Convert.ToInt32(data.Rows[0][0]);
                var CargaDiaria = CargaSemanal / 5;
                var idHorario = data.Rows[0][1].ToString();

                data.Clear();
                query = string.Format($"SELECT Dia, Inicio, Fim FROM BancoHoras WHERE IDFuncionario = {idFuncionario}");
                data = movimento.ConsultaQuery(query);

                query = string.Format($"SELECT SegundaIni, SegundaFim, TercaIni, TercaFim, QuartaIni, QuartaFim, QuintaIni, QuintaFim, SextaIni, SextaFim FROM Horarios WHERE ID = { idHorario}");
                var ponto = movimento.ConsultaQuery(query);
                if ((data == null || data.Rows.Count == 0) || (ponto == null || ponto.Rows.Count == 0))
                    return BadRequest();
                else
                {
                    var pontualidade = 0;
                    int horasPontuais = 0;
                    var horasExtras = new DateTime();
                    var horasFaltantes = new DateTime();
                    var saldo = new DateTime();

                    pontualidade = (pontualidade * 100)/ data.Rows.Count;

                    var dashboard = new DashboardDTO(saldo, pontualidade, horasPontuais, horasExtras, horasFaltantes);

                    return Ok(dashboard);
                }
            }                
        }
    }    
}
