using System.Data;

namespace API.Dtos
{
    public class DashboardDTO
    {
        public string Saldo { get; set; }
        public int Pontualidade { get; set; }
        public double HorasPontuais { get; set; }
        public string HorasExtras { get; set; }
        public string HorasFaltantes { get; set; }
        public int AcoesPendentes { get; set; }

        public DashboardDTO(DateTime saldo, int pontualidade, double horasPontuais, DateTime horasExtras, DateTime horasFaltantes)
        {
            this.Saldo = "04:05";
            this.Pontualidade = 78;
            this.HorasPontuais = 12;
            this.HorasExtras = "03:05";
            this.HorasFaltantes = "00:45";
            this.AcoesPendentes = 0;
        }
    }
}
