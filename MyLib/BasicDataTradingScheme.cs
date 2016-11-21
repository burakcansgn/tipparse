using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataTradingScheme
    {
        public readonly int s;
        public readonly int TRId;
        public readonly string Si;
        public readonly DateTime Dt;
        public readonly string Ms;
        public readonly TimeSpan St;

        public BasicDataTradingScheme(string name)
        {
            string[] words = name.Split(';');
            s = Int32.Parse(words[1].Substring(1, words[1].Length - 1));
            TRId = Int32.Parse(words[2].Substring(4, words[2].Length - 4));
            Si = words[3].Substring(2, words[3].Length - 2);
            Dt = DateTime.ParseExact(words[4].Substring(2, words[4].Length - 2),"yyyyMMdd", CultureInfo.InvariantCulture);
            Ms = words[5].Substring(2, words[5].Length - 2);
            St = TimeSpan.ParseExact(words[6].Substring(2, words[6].Length - 2), "hhmmss\\.fff",CultureInfo.InvariantCulture);

        }
    }
}