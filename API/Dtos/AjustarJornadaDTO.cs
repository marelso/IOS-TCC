using IOS.Models;
using System.Data;

namespace API.Dtos
{
    public class AjustarJornadaDTO
    {
        public Funcionarios Funcionario { get; set; }
        public Escalas Escala { get; set; }
        public Horarios Horario { get; set; }
        public double Intervalo { get; set; }
        public AjustarJornadaDTO()
        {
            this.Intervalo = 11.50;
            var funcionario = new Funcionarios();
            funcionario.IDSetor = 1;
            funcionario.NomeCompleto = "Marcelo Klein Sousa Junior";
            funcionario.CH = 30;
            funcionario.IDFuncao = 2;
            funcionario.Ativo = true;
            funcionario.CPF = "000.000.000.00";
            funcionario.RG = "00000000000";
            funcionario.Email = "email@gmail.com";
            funcionario.EmailALT = "emailAlternativo@gmail.com";
            funcionario.Telefone = "51 91111-1111";
            funcionario.Pais = "Brasil";
            funcionario.UF = "RS";
            funcionario.Cidade = "Porto Alegre";
            funcionario.Endereco = "Av. Endereço Taltaltal, Sarandi, 1010";
            funcionario.PIS = "00000000000";
            this.Funcionario = funcionario;

            var escala = new Escalas();
            escala.IDFuncionario = funcionario.ID;
            escala.ID = 2;
            escala.Segunda = true;
            escala.Terca = true;
            escala.Quarta = false;
            escala.Quinta = false;
            escala.Sexta = false;
            this.Escala = escala;

            var horario = new Horarios();
            horario.IDFuncionario = funcionario.ID;
            horario.ID = 2;
            horario.SegundaIni = DateTime.Now;
            horario.SegundaFim = DateTime.Now;
            horario.TercaIni = DateTime.Now;
            horario.TercaFim = DateTime.Now;
            horario.QuartaIni = DateTime.Now;
            horario.QuartaFim = DateTime.Now;
            horario.QuintaIni = DateTime.Now;
            horario.QuintaFim = DateTime.Now;
            horario.SextaIni = DateTime.Now;
            horario.SextaFim = DateTime.Now;
            this.Horario = horario;
        }
    }
}
