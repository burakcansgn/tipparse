using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class RAvTuple
    {
        public readonly int RAvInt;
        public readonly decimal RAvDecimal;

        public RAvTuple(int ravint, decimal ravdecimal)
        {
            RAvInt = ravint;
            RAvDecimal = ravdecimal;
        }
    }
}
