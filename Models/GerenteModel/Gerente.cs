using System;
using System.ComponentModel.DataAnnotations;
using FilmesAPI.Models.CinemaModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models.GerenteModel{

    public class Gerente
    {
        [Key]
        [Required]
        public int Id  {get; set;}
        
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [JsonIgnore]
        public virtual List<Cinema> Cinemas { get; set; }

    }
}