using AutoMapper;
using FilmesAPI.Models.GerenteModel;
using FilmesAPI.Data.DTOs.GerenteDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles{
    public class GerenteProfile : Profile{
        
        public GerenteProfile()
        {
            /*No código faz referencia a "... => gerente.Cinemas" onde Cinemas é a propriedade "public object Cinemas { get; set; }"
            da classe ReadGerenteDTO.cs. Este objeto é utilizado para retornar as colunas desejadas do cinema*/
            CreateMap<CreateGerenteDTO, Gerente>();
            CreateMap<Gerente, ReadGerenteDTO>()
                .ForMember(gerente => gerente.Cinemas, opts => opts
                .MapFrom(gerente => gerente.Cinemas.Select
                (c => new {c.Id, c.Nome, c.Endereco, c.EnderecoId})));
        }
    }


}