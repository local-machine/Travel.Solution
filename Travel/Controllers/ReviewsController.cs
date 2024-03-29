using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private TravelContext _db = new TravelContext();

        // GET api/reviews
        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get()
        {
            return _db.Reviews.ToList();
        }

        // POST api/reviews
        [HttpPost]
        public void Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
        }

        // PUT api/reviews/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Review review)
        {
            review.ReviewId = id;
            _db.Entry(review).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/reviews
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var reviewToDelete = _db.Reviews.FirstOrDefault(x => x.ReviewId == id);
            _db.Reviews.Remove(reviewToDelete);
            _db.SaveChanges();
        }
    }
}