using System.ComponentModel.DataAnnotations;

namespace BimmerRacing.Models
{
    public class Staffs
    {
        public int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required]
        [RegularExpression(@"^\(\d{3}\) \d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
        public required string Phone { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public int StoreId { get; set; }
        public required Store Store { get; set; }

        public int ManagerId { get; set; }
        public required Staff Manager { get; set; }
    }
}
