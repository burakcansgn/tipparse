using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public enum NOt
    {
        Exchange,
        Market,
        Orderbook,
        Instrument,
        Issuer,
        Source,
        None,
    };

    public class News
    {
        public readonly int s;
        public readonly int i;
        public readonly int NWi;
        public readonly TimeSpan t;
        public readonly NOt NOt;
        public readonly string NMs;
        public readonly string URl;
        public readonly string NHl;
        public readonly string TEx;
        public readonly int BLi;
        public readonly Boolean BLl;
        string[] checks = { "s", "i", "NWi", "t", "NOt", "NMs", "URl", "NHl", "TEx", "BLi", "BLl" };

        public News(string data)
        {
            string[] words = data.Split(';');
            for (int m = 1; m < words.Length; m++)
            {
                if (words[m].StartsWith(checks[0]))
                    s = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[1]))
                    i = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[2]))
                    NWi = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[3]))
                    t = TimeSpan.ParseExact(words[m].Substring(1, words[m].Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[4]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "1")
                        NOt = NOt.Exchange;
                    else if (words[m].Substring(3, words[m].Length - 3) == "2")
                        NOt = NOt.Market;
                    else if (words[m].Substring(3, words[m].Length - 3) == "3")
                        NOt = NOt.Orderbook;
                    else if (words[m].Substring(3, words[m].Length - 3) == "4")
                        NOt = NOt.Instrument;
                    else if (words[m].Substring(3, words[m].Length - 3) == "5")
                        NOt = NOt.Issuer;
                    else if (words[m].Substring(3, words[m].Length - 3) == "6")
                        NOt = NOt.Source;
                    else
                        NOt = NOt.None;
                }
                else if (words[m].StartsWith(checks[5]))
                    NMs = (words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[6]))
                    URl = (words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[7]))
                    NHl = (words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[8]))
                    TEx = (words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[9]))
                    BLi = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[10]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "N")
                        BLl = false;
                    else
                        BLl = true;
                }
            }

        }
    }
}