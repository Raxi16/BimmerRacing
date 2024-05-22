using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BimmerRacing.Models
{
    public class Order
    {
        [Key]
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

        [ForeignKey("Store")]
        public int StoreId { get; set; } // Store ID

        // Navigation properties
        public required Customers Customer { get; set; }
        public required Staff Staff { get; set; }
        public required Store Store { get; set; }
    }

    public class Customers
    {
    }
}


