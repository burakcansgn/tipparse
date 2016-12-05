using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataRight
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly decimal CSz;
        public readonly DateTime EXb;
        public readonly DateTime EXe;
        public readonly decimal TIs;
        public readonly int SEt;
        public readonly string EXc;
        public readonly Boolean HOt;
        string[] checks = { "i", "Si", "s", "CSz", "EXb", "EXe", "TIs", "SEt", "EXc", "HOt" };

        public BasicDataRight(string name)
        {
            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        i = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[1]))
                        Si = word.Substring(2, word.Length - 2);
                    else if (word.StartsWith(checks[2]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[3]))
                        CSz = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[4]))
                        EXb = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[5]))
                        EXe = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[6]))
                        TIs = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[7]))
                        SEt = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[8]))
                        EXc = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[9]))
                    {
                        if (word.Substring(3, word.Length - 3) == "N")
                            HOt = false;
                        else
                            HOt = true;
                    }
                }
            }
        }
    }
}

