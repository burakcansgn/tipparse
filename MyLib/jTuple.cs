using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class jTuple
    {
        public readonly int jInt;
        public readonly decimal jDecimal;

        public jTuple(int jint, decimal jdecimal)
        {
            jInt = jint;
            jDecimal = jdecimal;
        }
    }
}
