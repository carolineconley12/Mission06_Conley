using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Conley.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public required int CategoryId { get; set; }
        public Category Category { get; set; }

        public required string Title { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be no less than 1888.")]
        public required int Year { get; set; }

       
        public string? Director { get; set; }

        
        public string? Rating { get; set; }

        public required int Edited { get; set; }

        public string? LentTo { get; set; }

        public required int CopiedToPlex { get; set; }

        public string? Notes { get; set; }


    }
}



