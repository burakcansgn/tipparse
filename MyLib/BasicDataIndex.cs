using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataIndex
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly string SYm;
        public readonly string NAm;
        public readonly string LCy;
        public readonly int POt;
        public readonly int TYc;
        public readonly int ITy;
        public readonly int IPt;
        public readonly int Is;
        public readonly int Io;
        public readonly int Di;
        public readonly Boolean HOt;
        public readonly int SId;
        string[] checks = { "i", "Si", "s", "SYm", "NAm", "LCy", "POt", "TYc", "ITy", "IPt", "Is", "Io", "Di", "HOt", "SId" };

        public BasicDataIndex(string data)
        {
            string[] words = data.Split(';');
            for (int m = 1; m < words.Length; m++)
            {
                if (words[m].StartsWith(checks[0]))
                    i = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[1]))
                    Si = words[m].Substring(2, words[m].Length - 2);
                else if (words[m].StartsWith(checks[2]))
                    s = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[3]))
                    SYm = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[4]))
                    NAm = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[5]))
                    LCy = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[6]))
                    POt = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[7]))
                    TYc = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[8]))
                    ITy = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[9]))
                    IPt = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[10]))
                    Is = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[11]))
                    Io = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[12]))
                    Di = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[13]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "Y")
                        HOt = true;
                    else
                        HOt = false;
                }
                else if (words[m].StartsWith(checks[14]))
                    SId = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
            }
        }
    }
}
