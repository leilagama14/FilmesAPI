using FilmesAPI.Models.EnderecoModel;
using FilmesAPI.Models.GerenteModel;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs.CinemaDTO
{
    public class ReadCinemaDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; } 

        public Endereco Endereco { get; private set; }
        
        public Gerente Gerente { get; private set; }
       
    }
}