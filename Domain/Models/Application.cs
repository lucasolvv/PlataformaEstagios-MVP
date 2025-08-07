using PlataformaEstagios.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Applications")]
    public class Application
    {
        public int ApplicationId { get; set; }

        [Required]
        [ForeignKey("Vaga")]
        public int? VacancyId { get; set; }
        public Vacancy Vacancy { get; set; }

        [Required]
        [ForeignKey("Candidate")]
        public int? CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.UtcNow;
        public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
    }
}
