using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class TradeStatistics1
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly decimal Pl;
        public readonly decimal Pd;
        public readonly Boolean Of;
        public readonly decimal Dd;
        string[] checks = { "i", "s", "t", "Pl", "Pd", "Of", "Dd" };

        public TradeStatistics1(string name)
        {
            string[] words = name.Split(';');
            for (int m = 1; m < words.Length; m++)
            {

                if (words[m].StartsWith(checks[0]))
                    i = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[1]))
                    s = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[2]))
                    t = TimeSpan.ParseExact(words[m].Substring(1, words[m].Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[3]))
                    Pl = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[4]))
                    Pd = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[5]))
                {
                    if (words[m].Substring(2, words[m].Length - 2) == "Y")
                        Of = true;
                    else
                        Of = false;
                }
                else if (words[m].StartsWith(checks[4]))
                    Dd = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);

            }
        }
    }
}
