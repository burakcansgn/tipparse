using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class aTuple
    {
        public readonly int aInt;
        public readonly decimal aDecimal;

        public aTuple(int aint, decimal adecimal)
        {
            aInt = aint;
            aDecimal = adecimal;
        }
    }
}
