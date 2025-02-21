using System.ComponentModel.DataAnnotations;

namespace CadastroPessoaApp.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100)]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }
    }
}