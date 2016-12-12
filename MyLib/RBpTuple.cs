using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class RBpTuple
    {
        public readonly int RBpInt;
        public readonly decimal RBpDecimal;

        public RBpTuple(int rbpint, decimal rbpdecimal)
        {
            RBpInt = rbpint;
            RBpDecimal = rbpdecimal;

        }
    }
}
