using System.ComponentModel.DataAnnotations;

namespace MyntraClone.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
