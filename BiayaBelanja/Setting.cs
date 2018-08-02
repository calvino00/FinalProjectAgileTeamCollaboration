using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiayaBelanja
{
     public class Setting
    {

        public static string GetConnectionString()
        {
          return  @"Data Source = (localdb)\mssqllocaldb; 
                    Initial Catalog = BiayaBelanja; 
                    Integrated Security = True;";
        }
    }
}

