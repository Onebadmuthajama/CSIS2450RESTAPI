using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSIS_2450_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSIS_2450_Website.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CategoriesController : ControllerBase {
    private readonly TaskListContext _context;

    public CategoriesController(TaskListContext context) {
      _context = context;
    }

    // GET: api/Categories/1
    [HttpGet("{userId}")]
    public async Task<ActionResult<IEnumerable<Categories>>> GetCategories(int userId) {
      return await _context.Categories.Where(x => x.UserId == userId).ToListAsync();
    }

    // GET: api/Categories/1/5
    [HttpGet("{userId}/{id}")]
    public async Task<ActionResult<Categories>> GetCategory(int id) {
      var categories = await _context.Categories.FindAsync(id);

      if (categories == null) {
        return NotFound();
      }

      return categories;
    }

    // PUT: api/Categories/6
    [HttpPut("{id}")]
    public async Task<ActionResult<Categories>> PutCategories(int id, Categories categories) {
      if (id != categories.Id) {
        return BadRequest();
      }

      _context.Entry(categories).State = EntityState.Modified;

      try {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException) {
        if (!CategoriesExists(id)) {
          return NotFound();
        }
        else {
          return BadRequest();
        }
      }

      return categories;
    }

    // POST: api/Categories/1
    [HttpPost("{userId}")]
    public async Task<ActionResult<Categories>> PostCategories(int userId, Categories categories) {
      categories.UserId = userId;
      _context.Categories.Add(categories);
      await _context.SaveChangesAsync();

      return categories;
    }

    // DELETE: api/Categories/6
    [HttpDelete("{id}")]
    public async Task<ActionResult<Categories>> DeleteCategories(int id) {
      var categories = await _context.Categories.FindAsync(id);
      if (categories == null) {
        return NotFound();
      }

      _context.Categories.Remove(categories);
      await _context.SaveChangesAsync();

      return categories;
    }

    private bool CategoriesExists(int id) {
      return _context.Categories.Any(e => e.Id == id);
    }
  }
}