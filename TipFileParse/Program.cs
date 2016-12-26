using System;
using MyLib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipFileParse
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("tip_20150730_all.log");
            string[] items = text.Split('\n');
            for (int i = 0; i < items.Length; i++)
            {
                string[] messagefields = items[i].Split(';');
                if (messagefields[0] == "BDBu")
                {
                    BasicDataBusinessDate bdbu = new BasicDataBusinessDate(items[i]);
                }
                else if (messagefields[0] == "BDSr")
                {
                    BasicDataSource bdsr = new BasicDataSource(items[i]);
                }
                else if (messagefields[0] == "BDTe")
                {
                    BasicDataTableEntry bdte = new BasicDataTableEntry(items[i]);
                }
                else if (messagefields[0] == "BDTs")
                {
                    BasicDataTickSizeTable bdts = new BasicDataTickSizeTable(items[i]);
                }
                else if (messagefields[0] == "BDTz")
                {
                    BasicDataTickSizeEntry bdtz = new BasicDataTickSizeEntry(items[i]);
                }
                else if (messagefields[0] == "BDp")
                {
                    BasicDataParticipant bdp = new BasicDataParticipant(items[i]);
                }
                else if (messagefields[0] == "BDCv")
                {
                    BasicDataClearingVenue bdcv = new BasicDataClearingVenue(items[i]);
                }
                else if (messagefields[0] == "BDx")
                {
                    BasicDataExchange bdx = new BasicDataExchange(items[i]);
                }
            }
        }
    }
}

