using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliaController : ControllerBase
    {
       
        [HttpGet]
        public string Get()
        {
            return "livros";
        }

        [HttpGet("{sigla}/{capitulo}")]
        public string Get(string sigla, string capitulo)
        {
            return "sigla - capitulo";
        }

        [HttpGet("{sigla}/{capitulo}/{versiculo}")]
        public string Get(string sigla, string capitulo, string versiculo)
        {
            return "sigla - capitulo";
        }
    }
}
