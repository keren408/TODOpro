using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DatesWrapper
    {
        public DateTime startDate;
        public DateTime endDate;
        public DatesWrapper()
        {
            startDate = DateTime.Now;
            endDate = DateTime.Now;
        }
    }
}

