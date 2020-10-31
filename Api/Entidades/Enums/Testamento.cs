using System.ComponentModel;

namespace Api.Entidades.Enums
{
    public enum Testamento
    {
        [Description("Velho testamento")]
        Antigo = 1,

        [Description("Novo testamento")]
        Novo = 2,

        [Description("Novo e velho testamento")]
        NovoEVelho = 3
    }
}
