using PlataformaEstagios.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace PlataformaEstagios.Domain.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string NickName { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(100)]
        public string SenhaHash { get; set; }

        [Required]
        public TipoUsuario Tipo { get; set; }

    }
}
