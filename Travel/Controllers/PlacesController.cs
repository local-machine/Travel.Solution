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
    public class PlacesController : ControllerBase
    {
        private TravelContext _db = new TravelContext();

        // GET api/places
        [HttpGet]
        public ActionResult<IEnumerable<Place>> Get()
        {
            return _db.Places.ToList();
        }
        

        // POST api/places
        [HttpPost]
        public void Post([FromBody] Place place)
        {
            _db.Places.Add(place);
            _db.SaveChanges();
        }
        // GET api/places/5
        [HttpGet("{id}")]
        public ActionResult<Place> Get(int id)
        {
            return _db.Places.FirstOrDefault(x => x.PlaceId == id);
        }

        // PUT api/places/5
        [HttpPut("{id}")] 
        public void Put(int id, [FromBody] Place place)
        {
            place.PlaceId = id;
            _db.Entry(place).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/places
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var placeToDelete = _db.Places.FirstOrDefault(x => x.PlaceId == id);
            _db.Places.Remove(placeToDelete);
            _db.SaveChanges();
        }
         // GET api/places/city
        [HttpGet("city/{city}")]
        public ActionResult<Place> Get(string city)
        {
            return _db.Places.FirstOrDefault(x => x.City == city);
        }
        
         // GET api/places/country
        [HttpGet("country/{country}")]
        public ActionResult<Place> GetCountry(string country)
        {
            return _db.Places.FirstOrDefault(x => x.Country == country);
        }
    }
}