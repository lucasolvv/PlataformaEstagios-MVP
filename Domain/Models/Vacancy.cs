using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Vacancy")]
    public class Vacancy
    {
        public int VacancyId { get; set; }

        [Required]
        [ForeignKey("Empresa")]
        public int? EnterpriseId { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Application>? Applications { get; set; }
    }
}
