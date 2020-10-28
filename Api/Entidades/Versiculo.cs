namespace Api.Entidades
{
    public class Versiculo
    {
        public int Id { get; set; }
        public int LivroId { get; set; }
        public int Capitulo { get; set; }
        public int Numero { get; set; }
        public string Texto { get; set; }
    }
}
