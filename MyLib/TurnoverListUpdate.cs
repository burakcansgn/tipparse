using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class TurnoverListUpdate
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly decimal f;
        public readonly decimal o;
        public readonly int Bu;
        public readonly int Bp;
        public readonly int Bm;
        public readonly int Pu;
        public readonly int Pp;
        public readonly int Pm;
        public readonly int TNt;
        string[] checks = { "i", "s", "t", "f", "o", "Bu", "Bp", "Bm", "Pu", "Pp", "Pm", "TNt" };

        public TurnoverListUpdate(string data)
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
                    f = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[4]))
                    o = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[5]))
                    Bu = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[6]))
                    Bp = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[7]))
                    Bm = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[8]))
                    Pu = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[9]))
                    Pp = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[10]))
                    Pm = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[11]))
                    TNt = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
            }
        }
    }
}

