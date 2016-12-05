using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataDerivative
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly int DTy;
        public readonly decimal TIs;
        public readonly int DXt;
        public readonly decimal STp;
        public readonly decimal CSz;
        public readonly int SEt;
        public readonly DateTime EXb;
        public readonly DateTime EXe;
        public readonly DateTime Sd;
        public readonly Boolean HOt;
        string[] checks = { "i", "Si", "s", "DTy", "TIs", "DXt", "STp", "CSz", "SEt", "EXb", "EXe", "Sd", "HOt" };

        public BasicDataDerivative(string name)
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
                        DTy = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[4]))
                        TIs = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[5]))
                        DXt = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[6]))
                        STp = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[7]))
                        CSz = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[8]))
                        SEt = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[9]))
                        EXb = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[10]))
                        EXe = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[11]))
                       Sd = DateTime.ParseExact(word.Substring(2, word.Length - 2), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[12]))
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