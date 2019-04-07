using Microsoft.EntityFrameworkCore;
using CSIS_2450_Website.Models;

namespace CSIS_2450_Website.Models {
  public class TaskListContext : DbContext {
    public TaskListContext(DbContextOptions options) : base(options) { }

    public DbSet<Tasks> Tasks { get; set; }

    public DbSet<Categories> Categories { get; set; }

    public DbSet<CSIS_2450_Website.Models.User> User { get; set; }
  }
}