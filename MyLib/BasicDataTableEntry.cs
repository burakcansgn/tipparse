using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
   public class BasicDataTableEntry
    {
        public readonly int ID;
        public readonly string sID;
        public readonly int ss;
        public readonly int tet;
        public readonly string sym;
        public readonly string nm;
         

        public BasicDataTableEntry(string data)
        {
            string[] words = data.Split(';');
            ID = Int32.Parse(words[1].Substring(1, words[1].Length - 1));
            sID = words[2].Substring(2,words[2].Length-2);
            ss = Int32.Parse(words[3].Substring(1,words[3].Length-1));
            tet = Int32.Parse(words[4].Substring(3, words[4].Length-3));
            sym = words[5].Substring(3, words[5].Length - 3);
            nm = words[6].Substring(3, words[6].Length - 3);
        }

    }
}
