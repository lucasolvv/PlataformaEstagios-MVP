using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Candidates")]
    public class Candidate
    {
        [Required]
        [ForeignKey("Users")]
        public int? UserId { get; set; }
        public User? User { get; set; }
        
        [Required]
        public int CandidateId { get; set; }
        
        [Required, MaxLength(100)]
        public string Name { get; set; }
        
        [Required]
        public DateTime? BirthDate { get; set; }
        
        [Required]
        public string? CourseName { get; set; }

        //public int? CourseId { get; set; }
        //public Course? Course { get; set; }
        public Address? Address { get; set; }
        public ICollection<Application>? Applications { get; set; }
    }
}
