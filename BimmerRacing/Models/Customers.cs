using System.ComponentModel.DataAnnotations;

namespace BimmerRacing.Models
{
    public class Customers
    {
            public int Id { get; set; }

            [Required]
            public required string FirstName { get; set; }

            [Required]
            public required string LastName { get; set; }

            [Required]
            [RegularExpression(@"^\(\d{3}\) \d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
            [Phone]
            public required string Phone { get; set; }

            [Required]
            [EmailAddress]
            public required string Email { get; set; }

            [Required]
            public required string Street { get; set; }

            [Required]
            public required string City { get; set; }

            [Required]
            public required string Country { get; set; }

            [Required]
            [RegularExpression(@"^\d{5}$", ErrorMessage = "Invalid Postal Code")]
            public required string PostCode { get; set; }

        }
}
