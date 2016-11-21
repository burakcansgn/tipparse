using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataList
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly int PAi;
        public readonly string SYm;
        public readonly string NAm;
        public readonly string LCy;
        public readonly Boolean TCe;

        public BasicDataList(string name)
        {
            string[] words = name.Split(';');
            i = Int32.Parse(words[1].Substring(1, words[1].Length - 1));
            Si = words[2].Substring(2, words[2].Length - 2);
            s = Int32.Parse(words[3].Substring(1, words[3].Length - 1));
            if ((words[4].Substring(0, 3) != "PAi")) {
                SYm = (words[4].Substring(3, words[4].Length - 3));
                NAm = words[5].Substring(3, words[5].Length - 3);
                LCy = words[6].Substring(3, words[6].Length - 3);
                if (words[7].Substring(3, words[7].Length - 3) == "Y")
                    TCe = true;
                 else
                TCe = false;
            
        }
        else
            {
                PAi = Int32.Parse(words[4].Substring(3, words[4].Length - 3));
                SYm = (words[5].Substring(3, words[5].Length - 3));
                NAm = words[6].Substring(3, words[6].Length - 3);
                LCy = words[7].Substring(3, words[7].Length - 3);
                if (words[8].Substring(3, words[8].Length - 3) == "Y")
                    TCe = true;
                else
                    TCe = false;
            }
        }



       
    }
}
