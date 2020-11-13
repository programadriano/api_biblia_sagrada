using Api.Entidades.Enums;
using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entidades.Servicos
{
    public interface ILivroService
    {
        IEnumerable<Livro> ListarLivros();
        IEnumerable<Verso> BuscarVersosPorSiglaECapitulo(string sigla, int capitulo);
        IEnumerable<Verso> BuscarVersosPorSiglaCapituloEVersiculo(string sigla, int capitulo, int versiculo);
    }
}
