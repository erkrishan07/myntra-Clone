using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyntraClone.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewId { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime? ReviewDate { get; set; }
        public Products Products { get; set; }  // Navigation Property
        public Users Users { get; set; } // Navigation Property
       
    }
}
