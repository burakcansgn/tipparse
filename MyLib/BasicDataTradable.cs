using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class BasicDataTradable
    {
        #region 37parametre
        public readonly int i;
        public readonly string Si;
        public readonly int s;
        public readonly int Mk;
        public readonly string INi;
        public readonly string SYm;
        public readonly string NAm;
        public readonly string SNm;
        public readonly int ISi;
        public readonly string CUi;
        public readonly string CUt;
        public readonly int PRt;
        public readonly int VOd;
        public readonly DateTime LDa;
        public readonly DateTime TTd;
        public readonly string IEt;
        public readonly decimal NMv;
        public readonly int ITSz;
        public readonly int NDp;
        public readonly int NDTp;
        public readonly int CLId;
        public readonly string CNy;
        public readonly int SSc;
        public readonly int STy;
        public readonly Boolean AUm;
        public readonly Boolean TRa;
        public readonly Boolean PTa;
        public readonly int PTb;
        public readonly int MSe;
        public readonly Boolean HOt;
        public readonly decimal LSz;
        public readonly Boolean SSv;
        public readonly int MLm;
        public readonly int MLt;
        public readonly int TRId;
        public readonly int MMk;
        public readonly string TRm;
        public readonly Boolean GRs;
        private string[] checks = { "i", "Si", "s", "Mk", "INi", "SYm", "NAm", "SNm", "ISi", "CUi", "CUt", "PRt", "VOd", "LDa", "TTd", "IEt", "NMv", "ITSz", "NDp", "NDTp", "CLId", "CNy", "SSc", "STy", "AUm", "TRa", "PTa", "PTb", "MSe", "HOt", "LSz", "SSv", "MLm", "MLt", "TRId", "MMk", "TRm", "GRs" };
        #endregion
        public BasicDataTradable(string name)
        {
            string[] words = name.Split(';');
            foreach (string word in words)
            {
                foreach (string check in checks)
                {
                    #region 37if
                    if (word.StartsWith(checks[0]))
                        i = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[1]))
                        Si = word.Substring(2, word.Length - 2);
                    else if (word.StartsWith(checks[2]))
                        s = Int32.Parse(word.Substring(1, word.Length - 1));
                    else if (word.StartsWith(checks[3]))
                        Mk = Int32.Parse(word.Substring(2, word.Length - 2));
                    else if (word.StartsWith(checks[4]))
                        INi = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[5]))
                        SYm = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[6]))
                        NAm = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[7]))
                        SNm = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[8]))
                        ISi = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[9]))
                        CUi = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[10]))
                        CUt = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[11]))
                        PRt = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[12]))
                        VOd = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[13]))
                        LDa = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[14]))
                        LDa = DateTime.ParseExact(word.Substring(3, word.Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[15]))
                        IEt = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[16]))
                        NMv = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[17]))
                        ITSz = Int32.Parse(word.Substring(4, word.Length - 4));
                    else if (word.StartsWith(checks[18]))
                        NDp = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[19]))
                        NDTp = Int32.Parse(word.Substring(4, word.Length - 4));
                    else if (word.StartsWith(checks[20]))
                        CLId = Int32.Parse(word.Substring(4, word.Length - 4));
                    else if (word.StartsWith(checks[21]))
                        CNy = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[22]))
                        SSc = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[23]))
                        STy = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[24]))
                    {
                        if (word.Substring(3, word.Length - 3) == "N")
                            AUm = false;
                        else
                            AUm = true;
                    }
                    else if (word.StartsWith(checks[25]))
                    {
                        if (word.Substring(3, word.Length - 3) == "N")
                            TRa = false;
                        else
                            TRa = true;
                    }
                    else if (word.StartsWith(checks[26]))
                    {
                        if (word.Substring(3, word.Length - 3) == "N")
                            PTa = false;
                        else
                            PTa = true;
                    }
                    else if (word.StartsWith(checks[27]))
                        PTb = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[28]))
                        MSe = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[29]))
                    {
                        if (word.Substring(3, word.Length - 3) == "N")
                            HOt = false;
                        else
                            HOt = true;
                    }
                    else if (word.StartsWith(checks[30]))
                        LSz = decimal.Parse(word.Substring(3, word.Length - 3), CultureInfo.InvariantCulture);
                    else if (word.StartsWith(checks[31]))
                    {
                        if (word.Substring(3, word.Length - 3) == "N")
                            SSv = false;
                        else
                            SSv = true;
                    }
                    else if (word.StartsWith(checks[32]))
                        MLm = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[33]))
                        MLt = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[34]))
                        TRId = Int32.Parse(word.Substring(4, word.Length - 4));
                    else if (word.StartsWith(checks[35]))
                        MMk = Int32.Parse(word.Substring(3, word.Length - 3));
                    else if (word.StartsWith(checks[36]))
                        TRm = word.Substring(3, word.Length - 3);
                    else if (word.StartsWith(checks[37]))
                    {
                        if (word.Substring(3, word.Length - 3) == "N")
                            GRs = false;
                        else
                            GRs = true;
                    }
#endregion
                }
            }
        }
    }
}