using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataParticipant
    {
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly string SYm;
        public readonly string NAm;
        public readonly int PAt;
        public readonly string BIc;
        public readonly Boolean GRs;

        public BasicDataParticipant(string name)
        {
            string[] words = name.Split(';');
            i = Int32.Parse(words[1].Substring(1, words[1].Length - 1));
            Si = words[2].Substring(2, words[2].Length - 2);
            s = Int32.Parse(words[3].Substring(1, words[3].Length - 1));
            SYm = words[4].Substring(3, words[4].Length - 3);
            NAm = words[5].Substring(3, words[5].Length - 3);
            PAt = Int32.Parse(words[6].Substring(3, words[6].Length - 3));
            BIc = words[7].Substring(3, words[7].Length - 3);
            if (words[8].Substring(3, words[8].Length - 3) == "N")
                GRs = false;
            else
                GRs = true;

        }
    }
}
