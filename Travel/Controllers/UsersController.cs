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
    public class UsersController : ControllerBase
    {
        private TravelContext _db = new TravelContext();

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return _db.Users.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return _db.Users.FirstOrDefault(x => x.UserId == id);
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            user.UserId = id;
            _db.Entry(user).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/users
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var userToDelete = _db.Users.FirstOrDefault(x => x.UserId == id);
            _db.Users.Remove(userToDelete);
            _db.SaveChanges();
        }
    }
}