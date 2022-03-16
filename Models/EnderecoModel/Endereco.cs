using System;
using System.ComponentModel.DataAnnotations;
using FilmesAPI.Models.CinemaModel;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models.EnderecoModel{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id  {get; set;}
        
       [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        public string Logradouro{get; set;}

        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string Bairro {get; set;}

        [Required(ErrorMessage = "O campo Número é obrigatório")]
        public string Numero{get; set;}

        /*não retorna a propriedade Cinema. Evita que ocorra o erro de cycle.*/
        [JsonIgnore]
        public virtual Cinema Cinema { get; set; }
    }
}