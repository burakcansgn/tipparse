using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class OrderbookReferencePrice
    {
        public readonly int s;
        public readonly int i;
        public readonly TimeSpan t;
        public readonly decimal RPr;
        public readonly decimal ARp;
        public readonly decimal LPl;
        public readonly decimal UPl;
        string[] checks = { "s", "i", "t", "RPr", "ARp", "LPl", "UPl" };

        public OrderbookReferencePrice(string name)
        {
            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[1]))
                        i = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[2]))
                        t = TimeSpan.ParseExact(word.Substring(1, word.Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[3]))
                        RPr = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[4]))
                        ARp = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[5]))
                        LPl = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[6]))
                        UPl = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
