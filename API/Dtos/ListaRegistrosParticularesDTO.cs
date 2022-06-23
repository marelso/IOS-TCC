using System.Data;

namespace API.Dtos
{
    public class ListaRegistrosParticularesDTO
    {
        public int RegistrosSolicitados { get; set; }
        public int RegistrosAprovados { get; set; }
        public List<string> ListaRegistros { get; set; }

        public ListaRegistrosParticularesDTO()
        {
            var lista = new List<string>();
            lista.Add("Realização de exames");
            lista.Add("Solicitação de folga");
            lista.Add("Realização de exames");
            lista.Add("Licença médica");
            lista.Add("Realização de exames");

            this.RegistrosSolicitados = 10;
            this.RegistrosAprovados = 8;
            this.ListaRegistros = lista;
        }
    }
}
