using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs.EnderecoDTO{

    public class CreateEnderecoDTO{
        
                
        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        public string Logradouro{get; set;}

        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string Bairro {get; set;}

        [Required(ErrorMessage = "O campo Número é obrigatório")]
        public int Numero{get; set;}

    }
}