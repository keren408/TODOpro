using BE;
using PL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model
{
    class DisplayOneTodoModel
    {
        BL.BL bl;
        private DisplayOneTodoViewModel displayOneTodoViewModel;

        public DisplayOneTodoModel(DisplayOneTodoViewModel displayOneTodoVM)
        {
            this.displayOneTodoViewModel = displayOneTodoVM;
            bl = new BL.BL();
        }

        internal void updateTodo(TodoItem current)
        {
            bl.updateTodo(current);
        }

    }
}
