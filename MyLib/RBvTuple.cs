using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class RBvTuple
    {
        public readonly int RBvInt;
        public readonly decimal RBvDecimal;

        public RBvTuple(int rbvint,decimal rbvdecimal)
        {
            RBvInt = rbvint;
            RBvDecimal = rbvdecimal;
        }
    }
}
