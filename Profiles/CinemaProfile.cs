using AutoMapper;
using FilmesAPI.Models.CinemaModel;
using FilmesAPI.Data.DTOs.CinemaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles{
    public class CinemaProfile : Profile{
        
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDTO, Cinema>();
            CreateMap<Cinema, ReadCinemaDTO>();
            CreateMap<UpdateCinemaDTO, Cinema>();
        }
    }


}