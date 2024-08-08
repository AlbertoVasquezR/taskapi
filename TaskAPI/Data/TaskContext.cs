using Microsoft.EntityFrameworkCore;
using TaskModel = TaskAPI.Models.Task;

namespace TaskAPI.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}

