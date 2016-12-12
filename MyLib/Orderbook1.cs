using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Orderbook1
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly Boolean Of;
        public readonly int c;
        public readonly int e;
        public readonly decimal d;
        public readonly decimal b;
        public readonly decimal a;
        string[] checks = { "i", "s", "t", "Of", "c", "e", "d", "b", "a" };

        public Orderbook1(string name)
        {
            string[] words = name.Split(';');
            for (int j = 1; j < words.Length; j++)
            {

                if (words[j].StartsWith(checks[0]))
                    i = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                else if (words[j].StartsWith(checks[1]))
                    s = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                else if (words[j].StartsWith(checks[2]))
                    t = TimeSpan.ParseExact(words[j].Substring(1, words[j].Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[j].StartsWith(checks[3]))
                {
                    if (words[j].Substring(2, words[j].Length - 2) == "Y")
                        Of = true;
                    else
                        Of = false;
                }
                else if (words[j].StartsWith(checks[4]))
                    c = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                else if (words[j].StartsWith(checks[5]))
                    e = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                else if (words[j].StartsWith(checks[6]))
                    d = decimal.Parse(words[j].Substring(1, words[j].Length - 1), CultureInfo.InvariantCulture);
                else if (words[j].StartsWith(checks[7]))
                    b = decimal.Parse(words[j].Substring(1, words[j].Length - 1), CultureInfo.InvariantCulture);
                else if (words[j].StartsWith(checks[8]))
                    a = decimal.Parse(words[j].Substring(1, words[j].Length - 1), CultureInfo.InvariantCulture);

            }
        }
    }
}
