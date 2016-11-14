using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
   public class BasicDataTickSizeTable
    {
        
        public readonly int id;
        public readonly string si;
        public readonly int s;
        public readonly string nm;

        public BasicDataTickSizeTable(string name)
        {
            string[] words2 = name.Split(';');
            id = Int32.Parse(words2[1].Substring(1, words2[1].Length-1));
            si = words2[2].Substring(2, words2[2].Length - 2);
            s = Int32.Parse(words2[3].Substring(1, words2[3].Length - 1));
            nm = words2[4].Substring(4, words2[4].Length - 4);
        }

    }
}
