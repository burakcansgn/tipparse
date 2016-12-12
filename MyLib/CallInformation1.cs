using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class CallInformation1
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly decimal EQp;
        public readonly decimal EQv;
        string[] checks = { "i", "s", "t", "EQp", "EQv" };

        public CallInformation1(string data)
        {
            string[] words = data.Split(';');
            for (int m = 1; m < words.Length; m++)
            {
                if (words[m].StartsWith(checks[0]))
                    i = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[1]))
                    s = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[2]))
                    t = TimeSpan.ParseExact(words[m].Substring(1, words[m].Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[3]))
                    EQp = decimal.Parse(words[m].Substring(3, words[m].Length - 3), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[4]))
                    EQv = decimal.Parse(words[m].Substring(3, words[m].Length - 3), CultureInfo.InvariantCulture);
            }
        }
    }
}
