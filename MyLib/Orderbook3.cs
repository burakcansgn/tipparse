using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Orderbook3
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly Boolean Of;
        public readonly int c;
        public readonly int e;
        public readonly decimal d;
        public readonly decimal b;
        public readonly decimal g;
        public readonly int h;
        public readonly decimal a;
        public readonly decimal j;
        public readonly int k;
        public readonly decimal Bw;
        public readonly decimal Bt;
        public readonly decimal Aw;
        public readonly decimal At;
        string[] checks = { "i", "s", "t", "Of", "c", "e", "d", "b", "g", "h", "a", "m", "k","Bw","Bt","Aw","At"};

        public Orderbook3(string name)
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
                {
                    if (words[m].Substring(2, words[m].Length - 2) == "Y")
                        Of = true;
                    else
                        Of = false;
                }
                else if (words[m].StartsWith(checks[4]))
                    c = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[5]))
                    e = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[6]))
                    d = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[7]))
                    b = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[8]))
                    g = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[9]))
                    h = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[10]))
                    a = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[11]))
                    j = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[12]))
                    k = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[13]))
                    Bw = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[14]))
                    Bt = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[15]))
                    Aw = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[16]))
                    At = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
            }
        }
    }
}