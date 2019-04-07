using System.Linq;
using System.Threading.Tasks;
using CSIS_2450_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSIS_2450_Website.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase {
    private readonly TaskListContext _context;

    public UserController(TaskListContext context) {
      _context = context;
    }

    // GET: api/User
    [HttpGet("{username}/{password}")]
    public async Task<ActionResult<User>> GetUser(string username, string password) {
      var result = await _context.User.Where(x => x.Name == username && x.Password == password).SingleAsync();
      if (result != null) {
        return result;
      }

      return NoContent();
    }

    // GET: api/User/5
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int id) {
      var user = await _context.User.FindAsync(id);

      if (user == null) {
        return NotFound();
      }

      return user;
    }

    // PUT: api/User/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutUser(int id, User user) {
      if (id != user.Id) {
        return BadRequest();
      }

      _context.Entry(user).State = EntityState.Modified;

      try {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException) {
        if (!UserExists(id)) {
          return NotFound();
        }
        else {
          throw;
        }
      }

      return NoContent();
    }

    // POST: api/User
    [HttpPost]
    public async Task<ActionResult<User>> PostUser(User user) {
      _context.User.Add(user);
      await _context.SaveChangesAsync();

      return user;
    }

    // DELETE: api/User/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<User>> DeleteUser(int id) {
      var user = await _context.User.FindAsync(id);
      if (user == null) {
        return NotFound();
      }

      _context.User.Remove(user);
      await _context.SaveChangesAsync();

      return user;
    }

    private bool UserExists(int id) {
      return _context.User.Any(e => e.Id == id);
    }
  }
}