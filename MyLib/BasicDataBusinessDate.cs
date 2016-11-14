using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataBusinessDate
    {
        public readonly string date;
   

        public BasicDataBusinessDate(string data)
        {
            string[] words = data.Split(';');
            date = words[1].Substring(2, words[1].Length-2);            
        }


    }
    
}
