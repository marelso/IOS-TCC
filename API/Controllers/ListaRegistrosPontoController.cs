using IOS.Models;

namespace API.Controllers
{
    public class ListaRegistrosPontoController
    {
        public List<BancoHoras> Pontos { get; set; }

        public ListaRegistrosPontoController()
        {
            var pontos = new List<BancoHoras>();
            for(int i = 0; i <= 10; i++)
            {
                BancoHoras horas = new BancoHoras();
                horas.Dia = DateTime.Now;
                horas.Inicio = DateTime.Now;
                horas.Fim = DateTime.Now;
                horas.CargaDia = 6;
                pontos.Add(horas);
            }
        }
    }
}
