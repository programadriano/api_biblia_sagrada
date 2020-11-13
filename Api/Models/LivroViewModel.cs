using Api.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class LivroViewModel
    {
        public string Nome { get; set; }
        public int Capitulos { get; set; }
        public string Sigla { get; set; }
        public Testamento Testamento { get; set; }
    }
}
