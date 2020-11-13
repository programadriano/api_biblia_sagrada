using Api.Entidades;
using Api.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infra
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Livro, LivroViewModel>(); 

            CreateMap<Verso, CapituloViewModel>(); 
        }
    }
}
