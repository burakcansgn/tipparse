using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public enum SEd
    {
        None,
        StartofDay,
        EndofDay,

    };
    public class IndexSummary
    {

        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly decimal CLv;
        public readonly decimal Vh;
        public readonly decimal Vl;
        public readonly decimal o;
        public readonly decimal f;
        public readonly decimal OVa;
        public readonly decimal ODXv;
        public readonly decimal IXDv;
        public readonly decimal Dn;
        public readonly decimal Dd;
        public readonly decimal CAp;
        public readonly SEd Sed;
        string[] checks = { "i", "s", "t", "CLv", "Vh", "Vl", "o", "f", "OVa", "ODXv", "IXDv", "Dn", "Dd", "CAp", "SEd" };

        public IndexSummary(string name)
        {
            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        i = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[1]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[2]))
                        t = TimeSpan.ParseExact(word.Substring(1, word.Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[3]))
                        CLv = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[4]))
                        Vh = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[5]))
                        Vl = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[6]))
                        o = decimal.Parse(word.Substring(1, word.Length - 1), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[7]))
                        f = decimal.Parse(word.Substring(1, word.Length - 1), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[8]))
                        OVa = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[9]))
                        ODXv = decimal.Parse(word.Substring(4, word.Length - 4), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[10]))
                        IXDv = decimal.Parse(word.Substring(4, word.Length - 4), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[11]))
                        Dn = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[12]))
                        Dd = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[13]))
                        CAp = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[14]))
                    {
                        if (word.Substring(3, word.Length - 3) == "1")
                            Sed = SEd.StartofDay;
                        else if (word.Substring(3, word.Length - 3) == "2")
                            Sed = SEd.EndofDay;
                        else
                            Sed = SEd.None;
                    }
                }
            }
        }
    }
}
