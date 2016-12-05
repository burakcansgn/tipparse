using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataSectorMember
    {
        public readonly int IDo;
        public readonly int SId;
        public readonly int s;
        string[] checks = { "IDo", "SId", "s" };
        public BasicDataSectorMember(string name)
        {
            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        IDo = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[1]))
                        SId = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[2]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                }
            }
        }
    }
}