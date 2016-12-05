using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
   public class EndOfBasicData
    {
        public readonly int s;
        string[] checks = { "s" };

        public EndOfBasicData(string name)
        {
            string[] words = name.Split(';');

            foreach(string word in words)
            {
                foreach(string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                }
            }

        }
    }
}
