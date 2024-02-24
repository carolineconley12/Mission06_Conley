using System.ComponentModel.DataAnnotations;

namespace Mission06_Conley.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public required string CategoryName { get; set; }
    }
}
