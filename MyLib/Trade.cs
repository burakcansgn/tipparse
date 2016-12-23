using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Trade
    {
        public readonly int i;
        public readonly int s;
        public readonly int Tn;
        public readonly Boolean TCl;
        public readonly TimeSpan t;
        public readonly TimeSpan Ta;
        public readonly TimeSpan TCt;
        public readonly TimeSpan TDi;
        public readonly DateTime Sd;
        public readonly decimal p;
        public readonly decimal v;
        public readonly string Tb;
        public readonly string Ts;
        public readonly string Tt;
        public readonly Boolean Ul;
        public readonly Boolean Uh;
        public readonly Boolean Uv;
        public readonly Boolean Lt;
        public readonly DateTime Dx;
        public readonly DateTime Da;
        public readonly DateTime DDi;
        public readonly DateTime DCt;
        public readonly string Ti;
        public readonly string Ag;
        string[] checks = { "i", "s", "Tn", "TCl", "t", "Ta", "TCt", "TDi", "Sd", "p", "v", "Tb", "Ts", "Tt", "Ul", "Uh", "Uv", "Lt", "Dx", "Da", "DDi", "DCt", "Ti", "Ag" };

        public Trade(string data)
        {
            string[] words = data.Split(';');
            for (int m = 1; m < words.Length; m++)
            {
                if (words[m].StartsWith(checks[0]))
                    i = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[1]))
                    s = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[2]))
                    Tn = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[3]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "N")
                        TCl = false;
                    else
                        TCl = true;
                }
                else if (words[m].StartsWith(checks[4]))
                    t = TimeSpan.ParseExact(words[m].Substring(1, words[m].Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[5]))
                    Ta = TimeSpan.ParseExact(words[m].Substring(2, words[m].Length - 2), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[6]))
                    TCt = TimeSpan.ParseExact(words[m].Substring(3, words[m].Length - 3), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[7]))
                    TDi = TimeSpan.ParseExact(words[m].Substring(3, words[m].Length - 3), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[8]))
                    Sd = DateTime.ParseExact(words[m].Substring(2, words[m].Length - 2), "yyyyMMdd", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[9]))
                    p = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[10]))
                    v = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[11]))
                    Tb = words[m].Substring(2, words[m].Length - 2);
                else if (words[m].StartsWith(checks[12]))
                    Ts = words[m].Substring(2, words[m].Length - 2);
                else if (words[m].StartsWith(checks[13]))
                    Tt = words[m].Substring(2, words[m].Length - 2);
                else if (words[m].StartsWith(checks[14]))
                {
                    if (words[m].Substring(2, words[m].Length - 2) == "N")
                        Ul = false;
                    else
                        Ul = true;
                }
                else if (words[m].StartsWith(checks[15]))
                {
                    if (words[m].Substring(2, words[m].Length - 2) == "N")
                        Uh = false;
                    else
                        Uh = true;
                }
                else if (words[m].StartsWith(checks[16]))
                {
                    if (words[m].Substring(2, words[m].Length - 2) == "N")
                        Uv = false;
                    else
                        Uv = true;
                }
                else if (words[m].StartsWith(checks[17]))
                {
                    if (words[m].Substring(2, words[m].Length - 2) == "N")
                        Lt = false;
                    else
                        Lt = true;
                }
                else if (words[m].StartsWith(checks[18]))
                    Dx = DateTime.ParseExact(words[m].Substring(2, words[m].Length - 2), "yyyyMMdd", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[19]))
                    Da = DateTime.ParseExact(words[m].Substring(2, words[m].Length - 2), "yyyyMMdd", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[20]))
                    DDi = DateTime.ParseExact(words[m].Substring(3, words[m].Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[21]))
                    DCt = DateTime.ParseExact(words[m].Substring(3, words[m].Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[22]))
                    Ti = words[m].Substring(2, words[m].Length - 2);
                else if (words[m].StartsWith(checks[23]))
                    Ag = words[m].Substring(2, words[m].Length - 2);
            }
        }
    }
}
