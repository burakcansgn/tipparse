using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class TradeStatistics3
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly decimal Pf;
        public readonly decimal Pl;
        public readonly decimal Ph;
        public readonly decimal LOp;
        public readonly decimal Pd;
        public readonly int q;
        public readonly decimal o;
        public readonly decimal Rq;
        public readonly decimal f;
        public readonly decimal Rt;
        public readonly decimal LTRp;
        public readonly int LTRq;
        public readonly Boolean Of;
        string[] checks = { "i", "s", "t", "Pf", "Pl", "Ph", "LOp", "Pd", "q", "o", "Rq", "f", "Rt", "LTRp", "LTRq", "Of" };

        public TradeStatistics3(string data)
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
                    Pf = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[4]))
                    Pl = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[5]))
                    Ph = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[6]))
                    LOp = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[7]))
                    Pd = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[8]))
                    q = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[9]))
                    o = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[10]))
                    Rq = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[11]))
                    f = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[12]))
                    Rt = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[13]))
                    LTRp = decimal.Parse(words[m].Substring(4, words[m].Length - 4), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[14]))
                    LTRq = Int32.Parse(words[m].Substring(4, words[m].Length - 4));
                else if (words[m].StartsWith(checks[15]))
                {
                    if (words[m].Substring(2, words[m].Length - 2) == "Y")
                        Of = true;
                    else
                        Of = false;
                }
            }
        }
    }
}
