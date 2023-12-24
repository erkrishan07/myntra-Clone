using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyntraClone.Models
{
    public class OrderItems
    {
        [Key]
        public int OrderItemId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set;}
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public Order Order { get; set; } // Navigation Property
        public Products Products { get; set; } //Navigation Property
    }
}
