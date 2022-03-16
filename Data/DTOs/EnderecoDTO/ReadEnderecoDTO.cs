using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.DTOs.EnderecoDTO
{
    public class ReadEnderecoDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
                
        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        public string Logradouro{get; set;}

        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string Bairro {get; set;}

        [Required(ErrorMessage = "O campo Número é obrigatório")]
        public string Numero{get; set;}
    }
}