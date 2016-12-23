using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class IndexUpdate
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly decimal Vc;
        public readonly decimal Vh;
        public readonly decimal Vl;
        public readonly decimal o;
        public readonly decimal f;
        public readonly decimal OVa;
        public readonly decimal Dn;
        public readonly decimal Dd;
        string[] checks = { "i", "s", "t", "Vc", "Vh", "Vl", "o", "f", "OVa", "Dn", "Dd" };

        public IndexUpdate(string data)
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
                    Vc = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[4]))
                    Vh = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[5]))
                    Vl = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[6]))
                    o = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[7]))
                    f = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[8]))
                    OVa = decimal.Parse(words[m].Substring(3, words[m].Length - 3), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[9]))
                    Dn = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[10]))
                    Dd = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
            }
        }
    }
}

