using System.ComponentModel.DataAnnotations;

namespace Mission06_Conley.Models
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }

        [Required]
        public required string Category { get; set; }

        
        public required string Title { get; set; }

        [Required]
        public int Year { get; set; }

       
        public required string Director { get; set; }

        
        public required string Rating { get; set; }

        
        public bool? Edited { get; set; }

        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }


    }
}



