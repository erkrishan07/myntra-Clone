using System.ComponentModel.DataAnnotations;

namespace MyntraClone.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
