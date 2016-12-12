using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class MBPOrderSnapshot
    {
        public readonly int s;
        public readonly int i;
        public readonly TimeSpan t;
        public List<RBpTuple> RBptuple;
        public List<RBvTuple> RBvtuple;
        public List<RApTuple> RAptuple;
        public List<RAvTuple> RAvtuple;
        string[] checks = { "s", "i", "t", "RBp", "RBv", "RAp", "RAv" };

        public MBPOrderSnapshot(string data)
        {
            RBptuple = new List<RBpTuple>();
            RBvtuple = new List<RBvTuple>();
            RAptuple = new List<RApTuple>();
            RAvtuple = new List<RAvTuple>();
            string[] words = data.Split(';');
            for (int m = 1; m < words.Length; m++)
            {
                if (words[m].StartsWith(checks[0]))
                    s = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[1]))
                    i = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[2]))
                    t = TimeSpan.ParseExact(words[m].Substring(1, words[m].Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[3]))
                {
                    string[] RBpArray = words[m].Split(':');
                    int RBpInt = Int32.Parse(RBpArray[0].Substring(3, RBpArray[0].Length - 3));
                    decimal RBpDecimal = decimal.Parse(RBpArray[1], CultureInfo.InvariantCulture);
                    RBpTuple rbp = new RBpTuple(RBpInt, RBpDecimal);
                    RBptuple.Add(rbp);
                }

                else if (words[m].StartsWith(checks[4]))
                {
                    string[] RBvArray = words[m].Split(':');
                    int RBvInt = Int32.Parse(RBvArray[0].Substring(3, RBvArray[0].Length - 3));
                    decimal RBvDecimal = decimal.Parse(RBvArray[1], CultureInfo.InvariantCulture);
                    RBvTuple rbv = new RBvTuple(RBvInt, RBvDecimal);
                    RBvtuple.Add(rbv);
                }


                else if (words[m].StartsWith(checks[5]))
                {
                    string[] RApArray = words[m].Split(':');
                    int RApInt = Int32.Parse(RApArray[0].Substring(3, RApArray[0].Length - 3));
                    decimal RApDecimal = decimal.Parse(RApArray[1], CultureInfo.InvariantCulture);
                    RApTuple rap = new RApTuple(RApInt, RApDecimal);
                    RAptuple.Add(rap);
                }
                else if (words[m].StartsWith(checks[6]))
                {
                    string[] RAvArray = words[m].Split(':');
                    int RAvInt = Int32.Parse(RAvArray[0].Substring(3, RAvArray[0].Length - 3));
                    decimal RAvDecimal = decimal.Parse(RAvArray[1], CultureInfo.InvariantCulture);
                    RAvTuple rav = new RAvTuple(RAvInt, RAvDecimal);
                    RAvtuple.Add(rav);
                }
            }
        }
    }
}
