using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs.GerenteDTO{

    public class ReadGerenteDTO
    {
        [Key]
        [Required]
        public int Id  {get; set;}
        
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        /*Não foi utilizado o tipo "List<Cinemas>" na propriedade "Cinemas" porque ao
        executar um get da API no swagger estava entrando em loop pois, o Cinema tem 
        Gerente e o Gerente tem Cinema. Por isso o uso do tipo object.
        Obs.: A classe GerenteProfile.cs foi alterada para selecionar apenas as colunas desejadas no
        retorno do get*/
        public object Cinemas { get; set; }
        
    }
}

