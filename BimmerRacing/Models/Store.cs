using System.ComponentModel.DataAnnotations;

namespace BimmerRacing.Models
{
    public class Store
    {
        public int Id { get; set; } // Store ID

        [Required]
        public required string StoreName { get; set; }

        [Required]
        [RegularExpression(@"^\(\d{3}\) \d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
        public required string Phone { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string Street { get; set; }

        [Required]
        public required string City { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Invalid Post Code")]
        public required string PostCode { get; set; }

        // Navigation properties
        public required ICollection<Staff> Staff { get; set; }
        public required ICollection<Order> Orders { get; set; }
    }
}
