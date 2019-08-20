using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travel.Models
{
    [Table("reviews")]
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int PlaceId {get; set; }
  
    [Required]
        [StringLength(280)]
        public string Description { get; set; }
       

       [Required]
        [Range(1, 10,
            ErrorMessage = "Range should be at least between 1 and 10.")]
        public int Rating { get; set; }

        public virtual Place Place { get; set; }
    }
}