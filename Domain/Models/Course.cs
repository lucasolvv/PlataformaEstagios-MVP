using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string? Institution { get; set; }

        public ICollection<Candidate>? Candidates { get; set; }
    }
}
