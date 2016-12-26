using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataBusinessDate
    {
        public readonly DateTime date;
   

        public BasicDataBusinessDate(string data)
        {
            string[] words = data.Split(';');
            date =DateTime.ParseExact( words[1].Substring(2, words[1].Length-2),"yyyyMMdd", CultureInfo.InvariantCulture);

        }

        public override string ToString()
        {
            return this.GetType().Name + "\n\tdate=" + date.ToString();
        }
    }
    
}
