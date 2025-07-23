using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Candidatos")]
    public class Candidato
    {
        [Key]
        public int CandidatoId { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        [MaxLength(255)]
        public string? CurriculoUrl { get; set; }

        [ForeignKey("Curso")]
        public int? CursoId { get; set; }
        public Curso? Curso { get; set; }

        [ForeignKey("Endereco")]
        public int EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }

        public ICollection<Candidatura>? Candidaturas { get; set; }
    }
}
