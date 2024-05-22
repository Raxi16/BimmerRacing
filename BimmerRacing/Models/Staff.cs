using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BimmerRacing.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; } // Staff ID

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!; // First Name

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!; // Last Name

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+?\d{1,4}?[-.\s]?(\(?\d{1,3}?\)|\d{1,4})[-.\s]?\d{1,4}[-.\s]?\d{1,9}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = null!; // Phone

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!; // Email

        [ForeignKey("Store")]
        public int StoreId { get; set; } // Store ID

        [ForeignKey("Manager")]
        public int ManagerId { get; set; } // Manager ID (nullable)

        // Navigation properties
        public Store Store { get; set; } = null!; // Store

        public Staff? Manager { get; set; } // Manager

        public ICollection<Staff> Subordinates { get; set; } = new List<Staff>(); // For staff who manage other staff

        public ICollection<Order> Orders { get; set; } = new List<Order>(); // Orders handled by this staff
    }
}
