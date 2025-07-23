using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    public class Vaga
    {
        public int VagaId { get; set; }

        [Required]
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        [Required, MaxLength(100)]
        public string Titulo { get; set; }

        [MaxLength(1000)]
        public string? Descricao { get; set; }

        public bool Ativa { get; set; } = true;

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime? DataAtualizacao { get; set; }

        public ICollection<Candidatura>? Candidaturas { get; set; }
    }
}
