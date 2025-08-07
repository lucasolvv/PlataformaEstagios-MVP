using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEstagios.Domain.Models
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Required, MaxLength(100)]
        public string? Street { get; set; }

        [MaxLength(50)]
        public string? Complement { get; set; }

        [Required, MaxLength(50)]
        public string? Neighborhood { get; set; }

        [Required, MaxLength(50)]
        public string? City { get; set; }

        [Required, MaxLength(2)]
        public string? UF { get; set; }

        [Required, MaxLength(10)]
        public string? CEP { get; set; }
    }
}
