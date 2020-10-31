using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersosController : ControllerBase
    {
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
