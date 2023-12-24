using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyntraClone.Models
{
    public class CartItems
    {
        [Key]
        public int CartItemId { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Cart Cart { get; set; }  // Navigation Property.
        public Products Products { get; set; } // Navigation Property.

    }
}
