using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    //User defined exception class 
   public  class MinimumBasicException : Exception
    {
        
        public MinimumBasicException(string msg) : base(msg)
        {

        }
    }
}
