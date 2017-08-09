using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Views;
using PL.Model;
using System.Windows.Input;
using System.Windows;

namespace PL.ViewModel
{
    class searchByDateVM
    {
        searchByDateModel model;
        BE.DatesWrapper wrapper;
        ICommand okBut;
        private Window window;

        public searchByDateVM(BE.DatesWrapper wrapper , Window wdw)
        {
            OkBut = new CommandHandler(okFun, true);
            this.model = new searchByDateModel(this);
            this.wrapper = wrapper;
            this.window = wdw;
        }

        private void okFun()
        {
            window.Close();
        }

        public string StartDate
        {
            get
            {
                return wrapper.startDate.ToString("dd-MM-yyyy HH:mm");
            }
            set
            {
                wrapper.startDate = Convert.ToDateTime(value);
            }
        }
        public string EndDate
        {
            get { return wrapper.endDate.ToString("dd-MM-yyyy HH:mm"); }
            set { wrapper.endDate = Convert.ToDateTime(value); } }

        public ICommand OkBut { get { return okBut; } set { okBut = value; } }
    }
}
