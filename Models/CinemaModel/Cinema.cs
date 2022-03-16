using System;
using System.ComponentModel.DataAnnotations;
using FilmesAPI.Models.EnderecoModel;
using FilmesAPI.Models.GerenteModel;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models.CinemaModel{

    public class Cinema{

        [Key]
        [Required]
        public int Id  {get; set;}
        
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome{get; set;}

        /*Forma 01*/
        /* usando o Json ignore para resolver o problema de loop cíclico com [JsonIgnore]*/
        /*
        public int EnderecoId { get; set; }

        [JsonIgnore]
        public virtual Endereco Endereco { get; set; }

        public int GerenteId { get; set; }

        [JsonIgnore]
        public virtual Gerente Gerente { get; set; }
        */

        /*Forma 02*/
        /* usando a propriedade "object Cinema" na classe ReadGerenteDTO.cs
        e adicionando na GerenteProfile.cs o código:
            .ForMember(gerente => gerente.Cinemas, opts => opts
            .MapFrom(gerente => gerente.Cinemas.Select
            (c => new {c.Id, c.Nome, c.Endereco, c.EnderecoId})));
        */

        /*Usando a Forma 02*/
        public int EnderecoId { get; set; }
        
        public virtual Endereco Endereco { get; set; }
        
        public int GerenteId { get; set; }
        
        public virtual Gerente Gerente { get; set; }
    }
}