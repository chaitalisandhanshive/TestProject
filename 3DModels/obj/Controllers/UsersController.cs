using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _3DModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace _3DModels.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("default")]

    public class UsersController : ControllerBase
    {
        private readonly ModelDbContext _context;

        public UsersController(ModelDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetUsers()
        {
            return _context.users.ToList();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<Users> GetUsers(int id)
        {
            var user = _context.users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST: api/Users
        [HttpPost("CreateUser")]
        public ActionResult<Users> PostUsers(Users user)
        {
            _context.users.Add(user);
            _context.SaveChanges();

            return CreatedAtAction("GetUsers", new { id = user.user_id }, user);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public IActionResult PutUsers(int id, Users user)
        {
            if (id != user.user_id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public ActionResult<Users> DeleteUsers(int id)
        {
            var user = _context.users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.users.Remove(user);
            _context.SaveChanges();

            return user;
        }
    }
}
