using System.ComponentModel.DataAnnotations;

namespace PlataformaEstagios.Domain.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string? Instituicao { get; set; }

        public ICollection<Candidato> Candidatos { get; set; }
    }
}
