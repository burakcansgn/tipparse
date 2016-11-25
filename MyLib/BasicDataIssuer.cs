using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataIssuer
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly string SYm;
        public readonly string NAm;
        public readonly string CNy;
        private string[] checks = { "i", "Si", "s", "SYm", "NAm", "CNy" };

        public BasicDataIssuer(string name)
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
                        SYm = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[4]))
                        NAm = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[5]))
                        CNy = word.Substring(3, word.Length - 3);
                }
            }
        }
    }
}
