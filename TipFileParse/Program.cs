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
                    Console.WriteLine(bdbu.ToString());
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
                else if (messagefields[0] == "BDm")
                {
                    BasicDataMarket bdm = new BasicDataMarket(items[i]);
                }
                else if (messagefields[0] == "BDTd")
                {
                    BasicDataNonTradingDays bdtd = new BasicDataNonTradingDays(items[i]);
                }
                else if (messagefields[0] == "BDTm")
                {
                    BasicDataTradingScheme bdtm = new BasicDataTradingScheme(items[i]);
                }
                else if (messagefields[0] == "BDLi")
                {
                    BasicDataList bdli = new BasicDataList(items[i]);
                }
                else if (messagefields[0] == "BDs")
                {
                    BasicDataSector bds = new BasicDataSector(items[i]);
                }
                else if (messagefields[0] == "BDIs")
                {
                    BasicDataIssuer bdis = new BasicDataIssuer(items[i]);
                }
                else if (messagefields[0] == "BDt")
                {
                    BasicDataTradable bdt = new BasicDataTradable(items[i]);
                }
                else if (messagefields[0] == "BDTr")
                {
                    BasicDataTradableSupplementary bdtr = new BasicDataTradableSupplementary(items[i]);
                }
                else if (messagefields[0] == "BDSh")
                {
                    BasicDataShare bdsh = new BasicDataShare(items[i]);
                }
                else if (messagefields[0] == "BDDe")
                {
                    BasicDataDerivative bdde = new BasicDataDerivative(items[i]);
                }
                else if (messagefields[0] == "BDEt")
                {
                    BasicDataFund bdet = new BasicDataFund(items[i]);
                }
                else if (messagefields[0] == "BDRi")
                {
                    BasicDataRight bdri = new BasicDataRight(items[i]);
                }
                else if (messagefields[0] == "BDUi")
                {
                    BasicDataUnderlyingInfo bdui = new BasicDataUnderlyingInfo(items[i]);
                }
                else if (messagefields[0] == "m")
                {
                    OrderbookSummary m = new OrderbookSummary(items[i]);
                }
                else if (messagefields[0] == "BDLm")
                {
                    BasicDataListMember bdlm = new BasicDataListMember(items[i]);
                }
                else if (messagefields[0] == "BDSm")
                {
                    BasicDataSectorMember bdsm = new BasicDataSectorMember(items[i]);
                }
                else if (messagefields[0] == "EOBd")
                {
                    EndOfBasicData eobd = new EndOfBasicData(items[i]);
                }
                else if (messagefields[0] == "BDIn")
                {
                    BasicDataIndex bdin = new BasicDataIndex(items[i]);
                }
                else if (messagefields[0] == "BDIp")
                {
                    BasicDataIndexSupplementary bdip = new BasicDataIndexSupplementary(items[i]);
                }
                else if (messagefields[0] == "BDIm")
                {
                    BasicDataIndexMember bdim = new BasicDataIndexMember(items[i]);
                }
                else if (messagefields[0] == "Is")
                {
                    IndexSummary indexsum = new IndexSummary(items[i]);
                }
                else if (messagefields[0] == "Iw")
                {
                    IndexWeight indexw = new IndexWeight(items[i]);
                }
                else if (messagefields[0] == "TRh")
                {
                    CorporateAction trh = new CorporateAction(items[i]);
                }
                else if (messagefields[0] == "s")
                {
                    StateChange s = new StateChange(items[i]);
                }
                else if (messagefields[0] == "r")
                {
                    OrderbookReferencePrice r = new OrderbookReferencePrice(items[i]);
                }
                else if (messagefields[0] == "o")
                {
                    Orderbook1 o = new Orderbook1(items[i]);
                }
                else if (messagefields[0] == "p")
                {
                    Orderbook2 p = new Orderbook2(items[i]);
                }
                else if (messagefields[0] == "z")
                {
                    Orderbook3 z = new Orderbook3(items[i]);
                }
                else if (messagefields[0] == "u")
                {
                    TradeStatistics1 u = new TradeStatistics1(items[i]);
                }
                else if (messagefields[0] == "v")
                {
                    TradeStatistics2 v = new TradeStatistics2(items[i]);
                }
                else if (messagefields[0] == "w")
                {
                    TradeStatistics3 w = new TradeStatistics3(items[i]);
                }
            }
        }
    }
}

