using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class gTuple
    {
        public readonly int gInt;
        public readonly decimal gDecimal;

        public gTuple(int gint, decimal gdecimal)
        {
            gInt = gint;
            gDecimal = gdecimal;
        }
    }
}
