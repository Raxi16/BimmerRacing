using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BimmerRacing.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; } // Customer ID

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!; // First Name

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!; // Last Name

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!; // Email

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+?\d{1,4}?[-.\s]?(\(?\d{1,3}?\)|\d{1,4})[-.\s]?\d{1,4}[-.\s]?\d{1,9}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = null!; // Phone

        [Required]
        [StringLength(100)]
        public string Street { get; set; } = null!; // Street

        [Required]
        [StringLength(50)]
        public string City { get; set; } = null!; // City

        [Required]
        [StringLength(50)]
        public string Country { get; set; } = null!; // Country

        [Required]
        [StringLength(20)]
        public string PostCode { get; set; } = null!; // Post Code

        // Navigation properties
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Cart> Carts { get; set; } = new List<Cart>(); // Cart entries
    }
}
