using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class bTuple
    {
        public readonly int bInt;
        public readonly decimal bDecimal;

        public bTuple(int bint, decimal bdecimal)
        {
            bInt = bint;
            bDecimal = bdecimal;
        }
    }
}
