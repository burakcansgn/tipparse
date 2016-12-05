using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataShare
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly Boolean HOt;
        public readonly int AVq;
        public readonly DateTime As;
        public readonly DateTime Ae;
        public readonly int ICl;
        public readonly decimal TIs;
        string[] checks = { "i", "Si", "s", "HOt", "AVq", "As", "Ae", "ICl", "TIs" };

        public BasicDataShare(string name)
        {

            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        i = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[1]))

                        Si = word.Substring(2, word.Length-2);

                    else if (word.StartsWith(checks[2]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[3]))
                    {
                        if (word.Substring(3, word.Length - 3) == "N")
                            HOt = false;
                        else
                            HOt = true;
                    }
                    else if (word.StartsWith(checks[4]))
                        AVq = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[5]))
                        As = DateTime.ParseExact(word.Substring(2, word.Length - 2), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[6]))
                        Ae = DateTime.ParseExact(word.Substring(2, word.Length - 2), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[7]))
                        ICl = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[8]))
                        TIs = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);

                }
            }
        }
    }
}
