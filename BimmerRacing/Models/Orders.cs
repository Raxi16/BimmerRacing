using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BimmerRacing.Models
{
    public class Order
    {
        public int OrderId { get; set; } // Order ID

        [ForeignKey("Customer")]
        public int CustomerId { get; set; } // Customer ID

        [Required]
        [StringLength(20)]
        public required string OrderStatus { get; set; } // Order Status

        [DataType(DataType.Date)]
        public DateTime RequiredDate { get; set; } // Required Date

        [DataType(DataType.Date)]
        public DateTime ShippedDate { get; set; } // Shipped Date (nullable)

        [ForeignKey("Staff")]
        public int StaffId { get; set; } // Staff ID

        // Navigation properties
        public required Customer Customer { get; set; }

    }
}


