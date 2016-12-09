using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class CorporateAction
    {
        public readonly int i;
        public readonly int s;
        public readonly int SRe;
        public readonly int NOc;
        public readonly TimeSpan t;
        string[] checks = { "i", "s", "SRe", "NOc","t" };

        public CorporateAction(string name)
        {
            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        i = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[1]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[2]))
                        SRe = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[3]))
                        NOc = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[4]))
                        t = TimeSpan.ParseExact(word.Substring(1, word.Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                }
            }
        }
    }
}