using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Orderbook1
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly Boolean Of;
        public readonly int c;
        public readonly int e;
        public readonly decimal d;
        public List<bTuple> btuple;
        public List<aTuple> atuple;
        string[] checks = { "i", "s", "t", "Of", "c", "e", "d", "b", "a" };

        public Orderbook1(string name)
        {
            btuple = new List<bTuple>();
            atuple = new List<aTuple>();
            string[] words = name.Split(';');
            for (int j = 1; j < words.Length; j++)
            {

                if (words[j].StartsWith(checks[0]))
                    i = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                else if (words[j].StartsWith(checks[1]))
                    s = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                else if (words[j].StartsWith(checks[2]))
                    t = TimeSpan.ParseExact(words[j].Substring(1, words[j].Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[j].StartsWith(checks[3]))
                {
                    if (words[j].Substring(2, words[j].Length - 2) == "Y")
                        Of = true;
                    else
                        Of = false;
                }
                else if (words[j].StartsWith(checks[4]))
                    c = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                else if (words[j].StartsWith(checks[5]))
                    e = Int32.Parse(words[j].Substring(1, words[j].Length - 1));
                else if (words[j].StartsWith(checks[6]))
                    d = decimal.Parse(words[j].Substring(1, words[j].Length - 1), CultureInfo.InvariantCulture);
                else if (words[j].StartsWith(checks[7]))
                {
                    string[] bArray = words[j].Split(':');
                    int bInt = Int32.Parse(bArray[0].Substring(1, bArray[0].Length - 1));
                    decimal bDecimal = decimal.Parse(bArray[1], CultureInfo.InvariantCulture);
                    bTuple b = new bTuple(bInt, bDecimal);
                    btuple.Add(b);
                }
                else if (words[j].StartsWith(checks[8]))
                {
                    string[] aArray = words[j].Split(':');
                    int aInt = Int32.Parse(aArray[0].Substring(1, aArray[0].Length - 1));
                    decimal aDecimal = decimal.Parse(aArray[1], CultureInfo.InvariantCulture);
                    aTuple a = new aTuple(aInt, aDecimal);
                    atuple.Add(a);
                }

            }
        }
    }
}
