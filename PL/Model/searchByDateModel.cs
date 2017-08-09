using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.ViewModel;

namespace PL.Model
{
    class searchByDateModel
    {

        BL.BL bl;
        private searchByDateVM seaByDateVM;

        public searchByDateModel(searchByDateVM seaByDaVM)
        {
            this.seaByDateVM = seaByDaVM;
            bl = new BL.BL();
        }
    }
}
