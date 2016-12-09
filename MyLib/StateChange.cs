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
                        Ms = Int32.Parse(word.Substring(2, word.Length - 2));
                    else if (word.StartsWith(checks[4]))
                        Sl = Int32.Parse(word.Substring(2, word.Length - 2));
                    else if (word.StartsWith(checks[5]))
                    {
                        if (word.Substring(2, word.Length - 2) == "N")
                            Of = false;
                        else
                            Of = true;
                    }
                }
            }
        }
    }
}
