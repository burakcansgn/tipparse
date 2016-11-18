using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataSource
    {
        public readonly string Source;
        public readonly int Source2;
        

        public BasicDataSource(string name)
        {
            string[] words2 = name.Split(';');
            Source2 = Int32.Parse(words2[1].Substring(1, words2[1].Length - 1));
            Source = words2[2].Substring(3,words2[2].Length-3);
                                                        
        }
    }
}
