using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entidades.Servicos
{
    public interface IVersosService
    {
        IEnumerable<Verso> BuscarCapitulos(int livroId);
    }
}
