using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Enterprises")]
    public class Enterprise
    {
        [Key]
        public int EnterpriseId { get; set; }

        [Required]
        [ForeignKey("user")]
        public int UserId { get; set; }

        public User? User { get; set; }

        [MaxLength(255)]
        public string? EnterpriseName { get; set; }

        [MaxLength(20)]
        public string? Cnpj { get; set; }

        [MaxLength(100)]
        public string? ActivityArea { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public Address? Address { get; set; }

        public ICollection<Vacancy>? Vacancys { get; set; } = new List<Vacancy>();
    }
}
