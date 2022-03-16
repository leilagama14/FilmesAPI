using AutoMapper;
using FilmesAPI.Models.EnderecoModel;
using FilmesAPI.Data.DTOs.EnderecoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles{
    public class EnderecoProfile : Profile{
        
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDTO, Endereco>();
            CreateMap<Endereco, ReadEnderecoDTO>();
            CreateMap<UpdateEnderecoDTO, Endereco>();
        }
    }


}