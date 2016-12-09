using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
   public class StateChange
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly int Ms;
        public readonly int Sl;
        public readonly Boolean Of;
        string[] checks = { "i", "s", "t", "Ms", "Sl", "Of" };

        public StateChange(string name)
        {
            string[] words = name.Split(';');
            for (int j=1;j<words.Length;j++)
            {
                foreach (string check in checks)
                {
                    if (words[j].StartsWith(checks[0]))
                        i = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                    else if (words[j].StartsWith(checks[1]))
                        s = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                    else if (words[j].StartsWith(checks[2]))
                        t = TimeSpan.ParseExact(words[j].Substring(1, words[j].Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                    else if (words[j].StartsWith(checks[3]))
                        Ms = Int32.Parse(words[j].Substring(2, words[j].Length - 2));
                    else if (words[j].StartsWith(checks[4]))
                        Sl = Int32.Parse(words[j].Substring(2, words[j].Length - 2));
                    else if (words[j].StartsWith(checks[5]))
                    {
                        if (words[j].Substring(2, words[j].Length - 2) == "N")
                            Of = false;
                        else
                            Of = true;
                    }
                }
            }
        }
    }
}
