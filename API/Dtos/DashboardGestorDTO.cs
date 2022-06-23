using System.Data;

namespace API.Dtos
{
    public class DashboardGestorDTO
    {
        public DateTime Saldo { get; set; }
        public int Pontualidade { get; set; }
        public double HorasPontuais { get; set; }
        public double HorasExtras { get; set; }
        public double HorasFaltantes { get; set; }
        public int AcoesPendentes { get; set; }
        public int Funcionarios { get; set; }
        public int Solicitacoes { get; set; }

        public DashboardGestorDTO()
        {
            //this.Saldo = Convert.ToDateTime(dados.Rows[0][0]);
            //this.Pontualidade = Convert.ToInt32(dados.Rows[0][1]);
            //this.HorasPontuais = Convert.ToDateTime(dados.Rows[0][2]);
            //this.HorasExtras = Convert.ToDateTime(dados.Rows[0][3]);
            //this.HorasFaltantes = Convert.ToDateTime(dados.Rows[0][4]);
            //this.AcoesPendentes = Convert.ToInt32(dados.Rows[0][5]);
            this.Saldo = DateTime.Now;
            this.Pontualidade = 80;
            this.HorasPontuais = 16.50;
            this.HorasExtras = 15.30;
            this.HorasFaltantes = 2.10;
            this.AcoesPendentes = 10;
            this.Funcionarios = 10;
            this.Solicitacoes = 15;
        }
    }
}
