using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataSource
    {
        public readonly int i;
        public readonly string NAm;
       
        

        public BasicDataSource(string name)
        {
            string[] words2 = name.Split(';');
            i = Int32.Parse(words2[1].Substring(1, words2[1].Length - 1));
            NAm = words2[2].Substring(3,words2[2].Length-3);
                                                        
        }
    }
}
