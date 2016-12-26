using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class TradeStatistics2
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly decimal Pf;
        public readonly decimal Pl;
        public readonly decimal Ph;
        public readonly decimal LOp;
        public readonly decimal Pd;
        public readonly decimal LTRp;
        public readonly Boolean Of;
        string[] checks = { "i", "s", "t", "Pf", "Pl", "Ph", "LOp", "Pd", "LTRp", "Of" };

        public TradeStatistics2(string data)
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
                    LOp = decimal.Parse(words[m].Substring(3, words[m].Length - 3), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[7]))
                    Pd = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[8]))
                    LTRp = decimal.Parse(words[m].Substring(4, words[m].Length - 4), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[9]))
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
