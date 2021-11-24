using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Persistence.Context.TaskItems;
using ToDo.Persistence.Context.Users;
using ToDo.Persistence.Context.WorkItems;

namespace ToDo.Persistence.Context
{
    public class TodoContext: DbContext
    {
        public TodoContext( DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
        public DbSet<User> Users { get; set; }
        

    }
}
