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
        public readonly float d;
        public readonly float BPr;
        public readonly float APl;
        public readonly float Pf;
        public readonly float Pl;
        public readonly float Ph;
        public readonly float LOp;
        public readonly float Pd;
        public readonly int q;
        public readonly float o;
        public readonly float Rq;
        public readonly float f;
        public readonly float Rt;
        public readonly float SEp;
        public readonly float HPm;
        public readonly DateTime HPMd;
        public readonly float LPm;
        public readonly DateTime LPMd;
        public readonly float HPy;
        public readonly DateTime HPYd;
        public readonly float LPy;
        public readonly DateTime LPYd;
        public readonly DateTime LTd;
        public readonly DateTime LPd;
        public readonly float CWp;
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
                        d = float.Parse(word.Substring(1, word.Length - 1), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[7]))
                        BPr = float.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[8]))
                        APl = float.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[9]))
                        Pf = float.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[10]))
                        Pl = float.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[11]))
                        Ph = float.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[12]))
                        LOp = float.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[13]))
                        Pd = float.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[14]))
                        q = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[15]))
                        o = float.Parse(word.Substring(1, word.Length - 1), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[16]))
                        Rq = float.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[17]))
                        f = float.Parse(word.Substring(1, word.Length - 1), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[18]))
                        Rt = float.Parse(word.Substring(2, word.Length - 2), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[19]))
                        SEp = float.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[20]))
                        HPm = float.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[21]))
                        HPMd = DateTime.ParseExact(word.Substring(4, word.Length - 4), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[22]))
                        LPm = float.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[23]))
                        LPMd= DateTime.ParseExact(word.Substring(4, word.Length - 4), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[24]))
                        HPy = float.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[25]))
                        HPYd = DateTime.ParseExact(word.Substring(4, word.Length - 4), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[26]))
                        LPy = float.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[27]))
                        LPYd = DateTime.ParseExact(word.Substring(4, word.Length - 4), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[28]))
                        LTd = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[29]))
                        LPd = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[30]))
                        CWp = float.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);

                }
            }
        }
    }
}