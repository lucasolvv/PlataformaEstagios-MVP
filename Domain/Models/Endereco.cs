using System.ComponentModel.DataAnnotations;

namespace PlataformaEstagios.Domain.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required, MaxLength(100)]
        public string Logradouro { get; set; }

        [MaxLength(50)]
        public string? Complemento { get; set; }

        [Required, MaxLength(50)]
        public string Bairro { get; set; }

        [Required, MaxLength(50)]
        public string Cidade { get; set; }

        [Required, MaxLength(2)]
        public string UF { get; set; }

        [Required, MaxLength(10)]
        public string CEP { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
