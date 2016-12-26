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
        public List<int> MMk;
        public readonly string TRm;
        public readonly Boolean GRs;

        private string[] checks = { "i", "Si", "s", "Mk", "INi", "SYm", "NAm", "SNm", "ISi", "CUi", "CUt", "PRt", "VOd", "LDa", "TTd", "IEt", "NMv", "ITSz", "NDp", "NDTp", "CLId", "CNy", "SSc", "STy", "AUm", "TRa", "PTa", "PTb", "MSe", "HOt", "LSz", "SSv", "MLm", "MLt", "TRId", "MMk", "TRm", "GRs" };
        #endregion
        public BasicDataTradable(string name)
        {
            MMk = new List<int>();
            string[] words = name.Split(';');
            for (int m = 1; m < words.Length; m++)
            {
                #region 37if
                if (words[m].StartsWith(checks[0]))
                    i = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[1]))
                    Si = words[m].Substring(2, words[m].Length - 2);
                else if (words[m].StartsWith(checks[2]))
                    s = Int32.Parse(words[m].Substring(1, words[m].Length - 1));
                else if (words[m].StartsWith(checks[3]))
                    Mk = Int32.Parse(words[m].Substring(2, words[m].Length - 2));
                else if (words[m].StartsWith(checks[4]))
                    INi = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[5]))
                    SYm = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[6]))
                    NAm = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[7]))
                    SNm = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[8]))
                    ISi = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[9]))
                    CUi = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[10]))
                    CUt = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[11]))
                    PRt = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[12]))
                    VOd = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[13]))
                    LDa = DateTime.ParseExact(words[m].Substring(3, words[m].Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[14]))
                    LDa = DateTime.ParseExact(words[m].Substring(3, words[m].Length - 3), "yyyyMMdd", CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[15]))
                    IEt = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[16]))
                    NMv = decimal.Parse(words[m].Substring(3, words[m].Length - 3), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[17]))
                    ITSz = Int32.Parse(words[m].Substring(4, words[m].Length - 4));
                else if (words[m].StartsWith(checks[18]))
                    NDp = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[19]))
                    NDTp = Int32.Parse(words[m].Substring(4, words[m].Length - 4));
                else if (words[m].StartsWith(checks[20]))
                    CLId = Int32.Parse(words[m].Substring(4, words[m].Length - 4));
                else if (words[m].StartsWith(checks[21]))
                    CNy = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[22]))
                    SSc = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[23]))
                    STy = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[24]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "N")
                        AUm = false;
                    else
                        AUm = true;
                }
                else if (words[m].StartsWith(checks[25]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "N")
                        TRa = false;
                    else
                        TRa = true;
                }
                else if (words[m].StartsWith(checks[26]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "N")
                        PTa = false;
                    else
                        PTa = true;
                }
                else if (words[m].StartsWith(checks[27]))
                    PTb = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[28]))
                    MSe = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[29]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "N")
                        HOt = false;
                    else
                        HOt = true;
                }
                else if (words[m].StartsWith(checks[30]))
                    LSz = decimal.Parse(words[m].Substring(3, words[m].Length - 3), CultureInfo.InvariantCulture);
                else if (words[m].StartsWith(checks[31]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "N")
                        SSv = false;
                    else
                        SSv = true;
                }
                else if (words[m].StartsWith(checks[32]))
                    MLm = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[33]))
                    MLt = Int32.Parse(words[m].Substring(3, words[m].Length - 3));
                else if (words[m].StartsWith(checks[34]))
                    TRId = Int32.Parse(words[m].Substring(4, words[m].Length - 4));

                else if (words[m].StartsWith(checks[35]))
                {
                    string words1 = words[m].Substring(3, words[m].Length - 3);
                    string[] mmknums = words1.Split(',');
                    foreach (var mmknum in mmknums)
                    {
                        MMk.Add(Int32.Parse(mmknum));
                    }

                }

                else if (words[m].StartsWith(checks[36]))
                    TRm = words[m].Substring(3, words[m].Length - 3);
                else if (words[m].StartsWith(checks[37]))
                {
                    if (words[m].Substring(3, words[m].Length - 3) == "N")
                        GRs = false;
                    else
                        GRs = true;
                }
                #endregion
            }
        }
    }
}