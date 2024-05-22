using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BimmerRacing.Models
{
    public class Product
    {
        public int ProductId { get; set; } // Product ID

        [Required]
        [StringLength(100)]
        public required string ProductName { get; set; } // Product Name

        [ForeignKey("Category")]
        public int CategoryId { get; set; } // Category ID

        [Column(TypeName = "decimal(18,2)")]
        public decimal ListPrice { get; set; } // List Price

        public int Quantity { get; set; } // Quantity

        // Navigation property
        public required Category Category { get; set; }
    }
}
