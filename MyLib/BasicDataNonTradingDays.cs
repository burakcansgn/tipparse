using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataNonTradingDays
    {
        public readonly int s;
        public readonly int i;
        public readonly string Si;
        public readonly DateTime Dt;
        public readonly int TDt;

        public BasicDataNonTradingDays(string name)
        {
            string[] words = name.Split(';');
             s = Int32.Parse(words[1].Substring(1, words[1].Length-1));
             i = Int32.Parse(words[2].Substring(1, words[2].Length-1));
             Si = words[3].Substring(2, words[3].Length - 2);
             Dt =DateTime.ParseExact( words[4].Substring(2, words[4].Length - 2),"yyyyMMdd",null);
             TDt = Int32.Parse(words[5].Substring(3, words[5].Length - 3));   


        }
    }
}
