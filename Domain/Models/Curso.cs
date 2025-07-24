using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string? Instituicao { get; set; }

        public ICollection<Candidato>? Candidatos { get; set; }
    }
}
