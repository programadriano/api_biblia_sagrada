namespace Api.Entidades
{
    public class Verso
    {
        public int Id { get; set; }
        public int LivroId { get; set; }
        public int Capitulo { get; set; }
        public int Versiculo { get; set; }
        public string Texto { get; set; }
    }
}
