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
        public int UserId {get; set; }
  
        public string Description { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
    }
}