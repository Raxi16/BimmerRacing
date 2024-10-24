using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BimmerRacing.Models
{
    public class Product
    {
        public int ProductId { get; set; } // Product ID

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100)]
        public required string ProductName { get; set; } // Product Name

        [Column(TypeName = "nvarchar(100)")] // The file name for the image cannot exceed 100 characters.
        [DisplayName("Product Image")]
        public string ImageName { get; set; } // Name for image file

        [DisplayName("Product Image")]
        [Required(ErrorMessage = "The Product Image field is required.")]
        [NotMapped]
        public IFormFile ProductImage { get; set; } // Creates an Upload Image field for Product Images


        [ForeignKey("Category")]
        public int CategoryId { get; set; } // Category ID

        [Column(TypeName = "decimal(18,2)")]
        public decimal ListPrice { get; set; } // List Price

        public int Quantity { get; set; } // Quantity

        // Navigation property
        public required Category Category { get; set; }
    }
}
