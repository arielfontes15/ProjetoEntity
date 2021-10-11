using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AplicacaoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo {0} é Obrigatorio!")]
        public string Descricao { get; set; }
    }
}
