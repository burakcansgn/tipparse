using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataListMember
    {
        public readonly int IDo;
        public readonly int LSi;
        public readonly int s;
        public readonly Boolean HOt;
        string[] checks = { "IDo", "LSi", "s", "HOt" };

        public BasicDataListMember(string name)
        {
            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        IDo = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[1]))
                        LSi = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[2]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[3]))
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
