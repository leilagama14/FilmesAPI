using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs.CinemaDTO{

    public class CreateCinemaDTO
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        public int EnderecoId { get; set; }
        
        public int GerenteId { get; set; }
    }
}