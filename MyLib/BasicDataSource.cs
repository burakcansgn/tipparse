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


        public BasicDataSource(string osman)
        {
            string[] words2 = osman.Split(';');
            Source = words2[2].Substring(3,words2[2].Length-3);
                                                        
        }
    }
}
