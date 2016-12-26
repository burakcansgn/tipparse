using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Orderbook3
    {
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly Boolean Of;
        public readonly int c;
        public readonly int e;
        public readonly decimal d;
        public List<bTuple> btuple;
        public List<gTuple> gtuple;
        public readonly List<int> h;
        public List<aTuple> atuple;
        public List<jTuple> jtuple;
        public readonly List<int> k;
        public readonly decimal Bw;
        public readonly decimal Bt;
        public readonly decimal Aw;
        public readonly decimal At;
        string[] checks = { "i", "s", "t", "Of", "c", "e", "d", "b", "g", "h", "a", "m", "k", "Bw", "Bt", "Aw", "At" };

        public Orderbook3(string name)
        {
            h = new List<int>();
            k = new List<int>();
            btuple = new List<bTuple>();
            gtuple = new List<gTuple>();
            atuple = new List<aTuple>();
            jtuple = new List<jTuple>();
            string[] words = name.Split(';');
            for (int m = 1; m < words.Length; m++)
            {

                if (words[m].StartsWith(checks[0]))
                    i = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[1]))
                    s = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[2]))
                    t = TimeSpan.ParseExact(words[m].Substring(1, words[m].Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[3]))
                {
                    if (words[m].Substring(2, words[m].Length - 2) == "Y")
                        Of = true;
                    else
                        Of = false;
                }
                else if (words[m].StartsWith(checks[4]))
                    c = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[5]))
                    e = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[6]))
                    d = decimal.Parse(words[m].Substring(1, words[m].Length - 1), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[7]))
                {
                    string[] bArray = words[m].Split(':');
                    int bInt = Int32.Parse(bArray[0].Substring(1, bArray[0].Length - 1));
                    decimal bDecimal = decimal.Parse(bArray[1], CultureInfo.InvariantCulture);
                    bTuple b = new bTuple(bInt, bDecimal);
                    btuple.Add(b);
                }
                else if (words[m].StartsWith(checks[8]))
                {
                    string[] gArray = words[m].Split(':');
                    int gInt = Int32.Parse(gArray[0].Substring(1, gArray[0].Length - 1));
                    decimal gDecimal = decimal.Parse(gArray[1], CultureInfo.InvariantCulture);
                    gTuple g = new gTuple(gInt, gDecimal);
                    gtuple.Add(g);
                }
                else if (words[m].StartsWith(checks[9]))
                {
                    string words1 = words[m].Substring(1, words[m].Length - 1);
                    string[] hnums = words1.Split(':');
                    foreach (var hnum in hnums)
                    {
                        h.Add(Int32.Parse(hnum));
                    }
                }

                else if (words[m].StartsWith(checks[10]))
                {
                    string[] aArray = words[m].Split(':');
                    int aInt = Int32.Parse(aArray[0].Substring(1, aArray[0].Length - 1));
                    decimal aDecimal = decimal.Parse(aArray[1], CultureInfo.InvariantCulture);
                    aTuple a = new aTuple(aInt, aDecimal);
                    atuple.Add(a);
                }
                else if (words[m].StartsWith(checks[11]))
                {
                    string[] jArray = words[m].Split(':');
                    int jInt = Int32.Parse(jArray[0].Substring(1, jArray[0].Length - 1));
                    decimal jDecimal = decimal.Parse(jArray[1], CultureInfo.InvariantCulture);
                    jTuple j = new jTuple(jInt, jDecimal);
                    jtuple.Add(j);
                }
                else if (words[m].StartsWith(checks[12]))
                {
                    string words1 = words[m].Substring(1, words[m].Length - 1);
                    string[] knums = words1.Split(':');
                    foreach (var knum in knums)
                    {
                        k.Add(Int32.Parse(knum));
                    }
                }
                else if (words[m].StartsWith(checks[13]))
                    Bw = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[14]))
                    Bt = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[15]))
                    Aw = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[16]))
                    At = decimal.Parse(words[m].Substring(2, words[m].Length - 2), CultureInfo.InvariantCulture);
            }
        }
    }
}
