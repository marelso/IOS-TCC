using IOS.Models;
using System.Data;

namespace API.Dtos
{
    public class ListaFuncionariosDTO
    {
        public int SolicitacoesPendentes { get; set; }
        public int AbonosPendentes { get; set; }
        public List<Funcionarios> Funcionarios { get; set; }

        public ListaFuncionariosDTO()
        {
            this.SolicitacoesPendentes = 10;
            this.AbonosPendentes = 8;
            this.Funcionarios = new List<Funcionarios>();
        }
    }
}
