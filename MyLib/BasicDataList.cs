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
        string[] checks = { "i", "Si", "s", "PAi", "SYm", "NAm", "LCy", "TCe" };

        public BasicDataList(string name)
        {
            string[] words = name.Split(';');
            for (int m = 1; m < words.Length; m++)
            {
                if (words[m].StartsWith(checks[0]))
                    i = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[1]))
                    Si = words[m].Substring(2, words[m].Length - 2);
                else if (words[m].StartsWith(checks[2]))
                    s = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[3]))
                    PAi = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[4]))
                    SYm = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[5]))
                    NAm = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[6]))
                    LCy = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[7]))
                {
                    if (words[m].Substring(2, words[m].Length - 2) == "N")
                        TCe = false;
                    else
                        TCe = true;
                }
            }
        }
    }
}
