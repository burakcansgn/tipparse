using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
   public class BasicDataTableEntry
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly int TEt;
        public readonly string SYm;
        public readonly string NAm;
         

        public BasicDataTableEntry(string data)
        {
            string[] words = data.Split(';');
            i = Int32.Parse(words[1].Substring(1, words[1].Length - 1));
            Si = words[2].Substring(2,words[2].Length-2);
            s = Int32.Parse(words[3].Substring(1,words[3].Length-1));
            TEt = Int32.Parse(words[4].Substring(3, words[4].Length-3));
            SYm = words[5].Substring(3, words[5].Length - 3);
            NAm = words[6].Substring(3, words[6].Length - 3);
        }

    }
}
