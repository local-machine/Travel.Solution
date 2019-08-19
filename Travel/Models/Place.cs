using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travel.Models
{
    [Table("places")]
    public class Place
    {
        [Key]
        public int PlaceId { get; set; }
        
        public string City { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public Place()
        {
            this.Reviews = new HashSet<Review>();
        }
       
    }
}