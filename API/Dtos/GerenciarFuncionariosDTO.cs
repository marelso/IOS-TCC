using IOS.Models;
using System.Data;

namespace API.Dtos
{
    public class GerenciarFuncionariosDTO
    {
        public Funcionarios Funcionario { get; set; }
        public List<int> IdsFuncionarios { get; set; }

        public GerenciarFuncionariosDTO()
        {
            var funcionario = new Funcionarios();
            funcionario.NomeCompleto = "Marcelo Klein";
            funcionario.IDSetor = 2;
            funcionario.IDFuncao = 2;
            funcionario.IDEscala = 1;
            funcionario.IDHorario = 1;
            this.Funcionario = funcionario;

            var ids = new List<int>();
            ids.Add(1);
            ids.Add(2);
            ids.Add(3);

            this.IdsFuncionarios = ids;
        }
    }
}
