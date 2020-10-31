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
        IEnumerable<Livro> BuscarTodosLivros(int page, int qtd, Testamento testamento);

        IEnumerable<Capitulos> BuscarCapitulos(int livroId);
    }
}
