using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{

    public class IndexWeight
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly int IDo;
        public readonly decimal WPe;
        public readonly decimal FFr;
        public readonly decimal Wf;
        public readonly decimal WFv;
        public readonly decimal CAp;
        public readonly SEd Sed;
        string[] checks = { "i", "s", "t", "IDo", "WPe", "FFr", "Wf", "WFv", "CAp", "SEd" };

        public IndexWeight(string name)
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
                        IDo = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[4]))
                        WPe = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[5]))
                        FFr = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[6]))
                        Wf = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[7]))
                        WFv = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[8]))
                        CAp = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[9]))
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