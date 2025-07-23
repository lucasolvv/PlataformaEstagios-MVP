using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        [MaxLength(255)]
        public string? NomeFantasia { get; set; }

        [MaxLength(20)]
        public string? Cnpj { get; set; }

        [MaxLength(100)]
        public string? AreaAtuacao { get; set; }
        [ForeignKey("Endereco")]
        public int EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }

        public ICollection<Vaga> Vagas { get; set; } = new List<Vaga>();
    }
}
