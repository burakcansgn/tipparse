using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataMarket
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly int Ex;
        public readonly string SYm;
        public readonly string NAm;
        public readonly string TOTa;
        public readonly string LDa;
        public readonly string TTd;

        public BasicDataMarket(string name)
        {
            string[] words = name.Split(';');
            i = Int32.Parse(words[1].Substring(1, words[1].Length - 1));
            Si = words[2].Substring(2, words[2].Length - 2);
            s = Int32.Parse(words[3].Substring(1, words[3].Length - 1));
            Ex = Int32.Parse(words[4].Substring(2, words[4].Length - 2));
            NAm = words[5].Substring(3, words[5].Length - 3);
            SYm = words[6].Substring(3, words[6].Length - 3);
            TOTa = words[7].Substring(4, words[7].Length - 4);
            LDa = words[8].Substring(3, words[8].Length - 3);
            if (words[9] != "")
                TTd = words[9].Substring(3, words[9].Length - 3);
            else
                TTd = "";
          
        }
    }
}
