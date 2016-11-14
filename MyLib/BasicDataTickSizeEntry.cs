using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataTickSizeEntry
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly decimal TSz;
        public readonly decimal PFr;
        public readonly decimal PTo;

        public BasicDataTickSizeEntry(string name)
        {
            string[] words = name.Split(';');
            i = Int32.Parse(words[1].Substring(1, words[1].Length - 1));
            Si = words[2].Substring(2, words[2].Length - 2);
            s = Int32.Parse(words[3].Substring(1, words[3].Length - 1));
            TSz = decimal.Parse(words[4].Substring(3, words[4].Length - 3), CultureInfo.InvariantCulture);
            PFr = decimal.Parse(words[5].Substring(3, words[5].Length - 3), CultureInfo.InvariantCulture);
            PTo = decimal.Parse(words[6].Substring(3, words[6].Length - 3), CultureInfo.InvariantCulture);
        }

    }
}
