using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo {0} é Obrigatorio!")]
        public string Descricao { get; set; }
        [Range(1, 100, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
