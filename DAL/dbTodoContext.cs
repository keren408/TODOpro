using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dbTodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public dbTodoContext() : base()
        {
            
        }
    }
}
