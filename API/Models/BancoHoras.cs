namespace IOS.Models
{
    public class BancoHoras
    {
        public int ID { get; set; }
        public int IDFuncionario { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public double CargaDia { get; set; }
    }
}
