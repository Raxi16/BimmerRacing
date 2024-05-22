using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BimmerRacing.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // Category ID

        [Required]
        [StringLength(100)]
        public required string CategoryName { get; set; } // Category Name

        // Navigation property
        public required ICollection<Product> Products { get; set; }
    }
}

