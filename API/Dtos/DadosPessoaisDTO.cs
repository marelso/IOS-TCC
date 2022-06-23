using IOS.Models;
using System.Data;

namespace API.Dtos
{
    public class DadosPessoaisDTO
    {
        public Funcionarios Funcionario { get; set; }

        public DadosPessoaisDTO()
        {
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
        }
    }
}
