using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.ViewModel;
using BL;
using System.Windows;

namespace PL.Model
{
    public class AddTodoModel
    {
        BL.BL bl;
        private AddTodoViewModel addTodoViewModel;

        public AddTodoModel(AddTodoViewModel addTodoViewModel)
        {
            this.addTodoViewModel = addTodoViewModel;
            bl = new BL.BL();
        }

        internal void addTodo(TodoItem item)
        {
            if ((string.IsNullOrEmpty(item.Title) || string.IsNullOrEmpty(item.Description) || string.IsNullOrEmpty(item.Address) || string.IsNullOrEmpty(item.Color))) MessageBox.Show("You didnt fill all the details:(");
            bl.addTodo(item);
        }
    }
}
