using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   
    public class Factory
    {
        static TodoDBef instance = null;
        public static TodoDBef getFactoryDB()
        {
            if (instance == null)
                instance = new TodoDBef();
            return instance;
        }
    }
}
