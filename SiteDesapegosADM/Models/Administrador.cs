using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteDesapegosADM.Models
{
    [Table("AdminUsers")]
    public class Administrador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [StringLength(100, MinimumLength = 6)]
        public string Senha { get; set; }

    }
}
