using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs.GerenteDTO{

    public class CreateGerenteDTO
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

    }
}
