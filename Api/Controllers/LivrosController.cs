using System;
using System.Collections.Generic;
using Api.Entidades;
using Api.Entidades.Enums;
using Api.Entidades.Servicos;
using Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private ILivroService _service;
        private readonly IMapper _mapper;

        public LivrosController(ILivroService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;

        }


        [HttpGet("{sigla}/{capitulo}/{versiculo}")]
        public IActionResult Get(string sigla, int capitulo, int versiculo)
        {
            try
            {
                var domain = _service.BuscarVersosPorSiglaCapituloEVersiculo(sigla, capitulo, versiculo);
                var vm = _mapper.Map<IEnumerable<Verso>, IEnumerable<CapituloViewModel>>(domain);
                return Ok(vm);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{sigla}/{capitulo}")]
        public IActionResult Get(string sigla, int capitulo)
        {
            try
            {
                var domain = _service.BuscarVersosPorSiglaECapitulo(sigla, capitulo);
                var vm = _mapper.Map<IEnumerable<Verso>, IEnumerable<CapituloViewModel>>(domain);
                return Ok(vm);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var domain = _service.ListarLivros();
                var vm = _mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(domain);
                return Ok(vm);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
