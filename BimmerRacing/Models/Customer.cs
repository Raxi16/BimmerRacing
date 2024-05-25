using System.ComponentModel.DataAnnotations;

namespace BimmerRacing.Models
{
    public class Customer
    {
        public int CustomerID { get; set; } // Customer ID

        [Required]
        [StringLength(50)]
        public required string FirstName { get; set; } // First Name

        [Required]
        [StringLength(50)]
        public required string LastName { get; set; } // Last Name

        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; } // Email

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+?\d{1,4}?[-.\s]?(\(?\d{1,3}?\)|\d{1,4})[-.\s]?\d{1,4}[-.\s]?\d{1,9}$", ErrorMessage = "Invalid phone number")]
        public required string Phone { get; set; } // Phone

        [Required]
        [StringLength(100)]
        public required string Street { get; set; } // Street

        [Required]
        [StringLength(50)]
        public required string City { get; set; } // City

        [Required]
        [StringLength(50)]
        public required string Country { get; set; } // Country

        [Required]
        [StringLength(20)]
        public required string PostCode { get; set; } // Post Code

        // Navigation properties
        public ICollection<Order> Orders { get; set; } = new List<Order>(); // Orders
        public ICollection<Cart> Carts { get; set; } = new List<Cart>(); // Carts
        public ICollection<Payment> Payments { get; set; } = new List<Payment>(); // Payments
    }
}
