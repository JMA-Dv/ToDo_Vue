using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add-Migration (name)
//Remove-migration 
//Update-Database
//Update-Database name -> to return to (name) migration
namespace ToDo.Persistence.Context
{

    public interface IContextProvider
    {
        TodoContext TodoContext { get; }
    }
    public class ContextProvider : IContextProvider
    {
        private readonly IConfiguration _configuration;

        public ContextProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TodoContext TodoContext
        {
            get
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                var options = new DbContextOptionsBuilder<TodoContext>();
                options.UseSqlServer(connectionString);
                return new TodoContext(options.Options);
            }
        }
    }
}
