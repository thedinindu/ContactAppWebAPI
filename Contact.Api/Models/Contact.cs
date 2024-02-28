using System.ComponentModel.DataAnnotations;

namespace Contact.Api.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(15)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string? Address { get; set; }
        public bool IsActive { get; set; }
    }
}
