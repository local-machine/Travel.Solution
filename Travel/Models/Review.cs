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
  
        public string Description { get; set; }
       
        public int Rating { get; set; }

        public virtual Place Place { get; set; }
    }
}