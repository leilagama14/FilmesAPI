using AutoMapper;
using FilmesAPI.Models.FilmeModel;
using FilmesAPI.Data.DTOs.FilmeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles{
    public class FilmeProfile : Profile{
        
        public FilmeProfile()
        {
            // CreateMap<CreateFilmeDTO, Filme>();
            // CreateMap<Filme, ReadFilmeDTO>();
            // CreateMap<UpdateFilmeDTO, Filme>();
        }
    }


}