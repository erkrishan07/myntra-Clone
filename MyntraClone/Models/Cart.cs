using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyntraClone.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users{ get; set; }  //Navigation property 

    }
}
