using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.ViewModel;
namespace PL.Model
{
    class MainWindowModel
    {
        BL.BL bl;
        private MainWindowViewModel mainWin;

        public MainWindowModel(MainWindowViewModel mainWinViewModel)
        {
            this.mainWin = mainWinViewModel;
            bl = new BL.BL();
        }

        internal void delete(TodoItem currentSelected)
        {
            if (currentSelected != null)
                bl.deleteTodo(Int32.Parse(currentSelected.Id));
        }

        //internal bool update(TodoItem currentSelected)
        //{
        //    if (currentSelected != null)
        //        return bl.updateTodo(currentSelected);
        //    return false;
        //}
    }
}
