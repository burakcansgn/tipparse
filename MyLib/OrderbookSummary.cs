using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class OrderbookSummary
    {
        #region 31Parametre
        public readonly int i;
        public readonly int s;
        public readonly TimeSpan t;
        public readonly DateTime Dt;
        public readonly Boolean ISOc;
        public readonly Boolean ISOt;
        public readonly decimal d;
        public readonly decimal BPr;
        public readonly decimal APl;
        public readonly decimal Pf;
        public readonly decimal Pl;
        public readonly decimal Ph;
        public readonly decimal LOp;
        public readonly decimal Pd;
        public readonly int q;
        public readonly decimal o;
        public readonly decimal Rq;
        public readonly decimal f;
        public readonly decimal Rt;
        public readonly decimal SEp;
        public readonly decimal HPm;
        public readonly DateTime HPMd;
        public readonly decimal LPm;
        public readonly DateTime LPMd;
        public readonly decimal HPy;
        public readonly DateTime HPYd;
        public readonly decimal LPy;
        public readonly DateTime LPYd;
        public readonly DateTime LTd;
        public readonly DateTime LPd;
        public readonly decimal CWp;
        string[] checks = { "i", "s", "t", "Dt", "ISOc", "ISOt", "d", "BPr", "APl", "Pf", "Pl", "Ph", "LOp", "Pd", "q", "o", "Rq", "f", "Rt", "SEp", "HEp", "HPMd", "LPm", "LPMd", "HPy", "HPYd", "LPy", "LPYd", "LTd", "LPd", "CWp" };
        #endregion

        public OrderbookSummary(string name)
        {
            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    if (word.StartsWith(checks[0]))
                        i = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[1]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[2]))
                        t = TimeSpan.ParseExact(word.Substring(1, word.Length - 1), "hhmmss\\.fff", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[3]))
                        Dt = DateTime.ParseExact(word.Substring(2, word.Length - 2), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[4]))
                    {
                        if (word.Substring(4, word.Length - 4) == "N")
                            ISOc = false;
                        else
                            ISOc = true;
                    }
                    else if (word.StartsWith(checks[5]))
                    {
                        if (word.Substring(4, word.Length - 4) == "N")
                            ISOt = false;
                        else
                            ISOt = true;
                    }
                    else if (word.StartsWith(checks[6]))
                        d = decimal.Parse(word.Substring(1, word.Length - 1), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[7]))
                        BPr = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[8]))
                        APl = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[9]))
                        Pf = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[10]))
                        Pl = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[11]))
                        Ph = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[12]))
                        LOp = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[13]))
                        Pd = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[14]))
                        q = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[15]))
                        o = decimal.Parse(word.Substring(1, word.Length - 1), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[16]))
                        Rq = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[17]))
                        f = decimal.Parse(word.Substring(1, word.Length - 1), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[18]))
                        Rt = decimal.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[19]))
                        SEp = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[20]))
                        HPm = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[21]))
                        HPMd = DateTime.ParseExact(word.Substring(4, word.Length - 4), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[22]))
                        LPm = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[23]))
                        LPMd= DateTime.ParseExact(word.Substring(4, word.Length - 4), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[24]))
                        HPy = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[25]))
                        HPYd = DateTime.ParseExact(word.Substring(4, word.Length - 4), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[26]))
                        LPy = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[27]))
                        LPYd = DateTime.ParseExact(word.Substring(4, word.Length - 4), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[28]))
                        LTd = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[29]))
                        LPd = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[30]))
                        CWp = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);

                }
            }
        }
    }
}