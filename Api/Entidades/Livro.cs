using Api.Entidades.Enums;

namespace Api.Entidades
{
    public class Livro
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public int Capitulos { get; set; }
        public string Grupo { get; set; }
        public string Nome { get; set; }
        public Testamento Testamento { get; set; }
        public string Sigla { get; set; }
        
    }
}
