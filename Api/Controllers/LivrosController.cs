using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entidades;
using Api.Entidades.Enums;
using Api.Entidades.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private ILivroService _service;

        public LivrosController(ILivroService service)
        {
            _service = service;
        }

        [HttpGet("{page}/{qtd}/{testamento}")]
        public IActionResult Get(int page, int qtd, Testamento testamento)
        {
            try
            {
                return Ok(_service.BuscarTodosLivros(page, qtd, testamento));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{livroId}")]
        public IActionResult Get(int livroId)
        {
            try
            {
                return Ok(_service.BuscarCapitulos(livroId));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
