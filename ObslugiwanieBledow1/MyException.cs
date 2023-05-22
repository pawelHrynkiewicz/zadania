using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugiwanieBledow1
{
    class MyException : Exception
    {
        public string NumString;

        public MyException()
            :base("co to zrobi");
    }
}
