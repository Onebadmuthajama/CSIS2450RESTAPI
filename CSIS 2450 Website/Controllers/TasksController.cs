using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSIS_2450_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSIS_2450_Website.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class TasksController : ControllerBase {
    private readonly TaskListContext _context;

    public TasksController(TaskListContext context) {
      _context = context;
    }

    // GET: api/Tasks
    [HttpGet("{categoryId}")]
    public async Task<List<Tasks>> GetTask(int categoryId) {
      return await _context.Tasks.Where(x => x.CategoryId == categoryId).ToListAsync();
    }

    // GET: api/Tasks/5
    [HttpGet("{id}/{categoryId}")]
    public async Task<ActionResult<Tasks>> GetTask(int id, int categoryId) {
      var task = await _context.Tasks.FindAsync(id);

      if (task == null) {
        return NotFound();
      }

      return task;
    }

    // PUT: api/Tasks/5
    [HttpPut("{id}")]
    public async Task<ActionResult<Tasks>> PutTask(int id, Tasks task) {
      if (id != task.Id) {
        return BadRequest();
      }

      _context.Entry(task).State = EntityState.Modified;

      try {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException) {
        if (!TaskExists(id)) {
          return NotFound();
        }
        else {
          throw;
        }
      }

      return task;
    }

    // POST: api/Tasks
    [HttpPost("{categoryId}")]
    public async Task<ActionResult<Tasks>> PostTask(int categoryId, Tasks task) {
      task.CategoryId = categoryId;
      _context.Tasks.Add(task);
      await _context.SaveChangesAsync();

      return task;
    }

    // DELETE: api/Tasks/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Tasks>> DeleteTask(int id) {
      var task = await _context.Tasks.FindAsync(id);
      if (task == null) {
        return NotFound();
      }

      _context.Tasks.Remove(task);
      await _context.SaveChangesAsync();

      return task;
    }

    private bool TaskExists(int id) {
      return _context.Tasks.Any(e => e.Id == id);
    }
  }
}