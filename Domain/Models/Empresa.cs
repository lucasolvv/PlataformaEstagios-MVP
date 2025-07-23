using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [MaxLength(255)]
        public string? NomeFantasia { get; set; }
        public string? Cnpj { get; set; }
        public string? AreaAtuacao { get; set; }
        public Endereco? Endereco { get; set; }

        public ICollection<Vaga> Vagas { get; set; } = new List<Vaga>();
    }
}
