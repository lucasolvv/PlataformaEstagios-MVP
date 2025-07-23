using PlataformaEstagios.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    public class Candidatura
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Vaga")]
        public int VagaId { get; set; }
        public Vaga Vaga { get; set; }

        [Required]
        [ForeignKey("Candidato")]
        public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
        public DateTime DataCandidatura { get; set; } = DateTime.UtcNow;
        public StatusCandidatura Status { get; set; } = StatusCandidatura.Pendente;
    }
}
