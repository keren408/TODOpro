using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.ViewModel;
namespace PL.Model
{
    class DisplayMyTodoModel
    {
        DisplayMyTodoViewModel viewmodel;
        BL.BL bl;

        public DisplayMyTodoModel(DisplayMyTodoViewModel viewmodel)
        {
            this.viewmodel = viewmodel;
            bl = new BL.BL();

        }

        internal List<TodoItem> getAllTodo(Predicate<TodoItem> filter)
        {
            return bl.getAllTodo(filter);
        }

        internal List<TodoItem> getAllTodo()
        {
            return bl.getAllTodo();
        }
    }
}
