using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BimmerRacing.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } // Payment ID

        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; } // Customer ID

        [Required]
        [DataType(DataType.Currency)]
        public decimal PayAmount { get; set; } // Pay Amount

        [Required]
        [StringLength(50)]
        public required string PayMethod { get; set; } // Pay Method

        [Required]
        [DataType(DataType.Date)]
        public DateTime PayDate { get; set; } // Pay Date

        // Navigation property
        public required Customer Customer { get; set; }
    }
}

