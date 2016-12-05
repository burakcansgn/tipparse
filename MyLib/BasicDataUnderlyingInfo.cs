using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataUnderlyingInfo
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly int ULi;
        public readonly string DSc;
        public readonly Boolean HOt;
        string[] checks = { "i", "Si", "s", "ULi", "DSc", "Hot" };

        public BasicDataUnderlyingInfo(string name)
        {
            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        i = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[1]))
                        Si = word.Substring(2, word.Length - 2);
                    else if (word.StartsWith(checks[2]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[3]))
                        ULi = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[4]))
                        DSc = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[5]))
                    {
                        if (word.Substring(3, word.Length - 3) == "N")
                            HOt = false;
                        else
                            HOt = true;
                    }
                }
            }
        }
    }
}
