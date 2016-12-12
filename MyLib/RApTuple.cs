using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class RApTuple
    {
        public readonly int RApInt;
        public readonly decimal RApDecimal;

        public RApTuple(int rapint, decimal rapdecimal)
        {
            RApInt = rapint;
            RApDecimal = rapdecimal;
        }
    }
}
