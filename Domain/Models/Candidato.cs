using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PlataformaEstagios.Domain.Contracts.NewUserContracts;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Candidato")]
    public class Candidato
    {
        public int CandidatoId { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }

        [MaxLength(255)]
        public string? CurriculoUrl { get; set; }
        public int? CursoId { get; set; }
        public Curso? Curso { get; set; }
        public Endereco? Endereco { get; set; }
        public ICollection<Candidatura>? Candidaturas { get; set; }
    }
}
