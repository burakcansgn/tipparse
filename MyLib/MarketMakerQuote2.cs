using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class MarketMakerQuote2
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly decimal Pa;
        public readonly decimal Pb;
        public readonly decimal Vb;
        public readonly decimal Va;
        string[] checks = { "i", "s", "t", "Pa", "Pb", "Vb", "Va" };

        public MarketMakerQuote2(string data)
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
                    Pa = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[4]))
                    Pb = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[5]))
                    Vb = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[6]))
                    Va = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
            }
        }
    }
}
