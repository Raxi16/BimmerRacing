using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BimmerRacing.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; } // Cart ID

        [ForeignKey("Product")]
        public int ProductId { get; set; } // Product ID

        [ForeignKey("Customer")]
        public int CustomerId { get; set; } // Customer ID

        [Required]
        [DataType(DataType.Currency)]
        public decimal ListPrice { get; set; } // List Price

        [Required]
        public int Quantity { get; set; } // Quantity

        // Navigation properties
        public Product Product { get; set; } = null!; // Product
        public Customers Customer { get; set; } = null!; // Customer
    }
}
