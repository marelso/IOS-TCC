namespace IOS.Models
{
    public class Funcionarios
    {
        public int ID { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string PIS { get; set; }
        public string Pais { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string EmailALT { get; set; }
        public string Telefone { get; set; }
        public int CH { get; set; }
        public int IDSetor { get; set; }
        public int IDFuncao { get; set; }
        public int IDEscala { get; set; }
        public int IDHorario { get; set; }
        public int IDLogin { get; set; }
        public bool Ativo { get; set; }
    }
}
