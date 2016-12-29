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
            string[] tipMessages = text.Split('\n');
            for (int i = 0; i < tipMessages.Length; i++)
            {
                string[] messagefields = tipMessages[i].Split(';');
                if (messagefields[0] == "BDBu")
                {
                    BasicDataBusinessDate bdbu = new BasicDataBusinessDate(tipMessages[i]);
                    Console.WriteLine(bdbu.ToString());
                }
                else if (messagefields[0] == "BDSr")
                {
                    BasicDataSource bdsr = new BasicDataSource(tipMessages[i]);
                }
                else if (messagefields[0] == "BDTe")
                {
                    BasicDataTableEntry bdte = new BasicDataTableEntry(tipMessages[i]);
                }
                else if (messagefields[0] == "BDTs")
                {
                    BasicDataTickSizeTable bdts = new BasicDataTickSizeTable(tipMessages[i]);
                }
                else if (messagefields[0] == "BDTz")
                {
                    BasicDataTickSizeEntry bdtz = new BasicDataTickSizeEntry(tipMessages[i]);
                }
                else if (messagefields[0] == "BDp")
                {
                    BasicDataParticipant bdp = new BasicDataParticipant(tipMessages[i]);
                }
                else if (messagefields[0] == "BDCv")
                {
                    BasicDataClearingVenue bdcv = new BasicDataClearingVenue(tipMessages[i]);
                }
                else if (messagefields[0] == "BDx")
                {
                    BasicDataExchange bdx = new BasicDataExchange(tipMessages[i]);
                }
                else if (messagefields[0] == "BDm")
                {
                    BasicDataMarket bdm = new BasicDataMarket(tipMessages[i]);
                }
                else if (messagefields[0] == "BDTd")
                {
                    BasicDataNonTradingDays bdtd = new BasicDataNonTradingDays(tipMessages[i]);
                }
                else if (messagefields[0] == "BDTm")
                {
                    BasicDataTradingScheme bdtm = new BasicDataTradingScheme(tipMessages[i]);
                }
                else if (messagefields[0] == "BDLi")
                {
                    BasicDataList bdli = new BasicDataList(tipMessages[i]);
                }
                else if (messagefields[0] == "BDs")
                {
                    BasicDataSector bds = new BasicDataSector(tipMessages[i]);
                }
                else if (messagefields[0] == "BDIs")
                {
                    BasicDataIssuer bdis = new BasicDataIssuer(tipMessages[i]);
                }
                else if (messagefields[0] == "BDt")
                {
                    BasicDataTradable bdt = new BasicDataTradable(tipMessages[i]);
                }
                else if (messagefields[0] == "BDTr")
                {
                    BasicDataTradableSupplementary bdtr = new BasicDataTradableSupplementary(tipMessages[i]);
                }
                else if (messagefields[0] == "BDSh")
                {
                    BasicDataShare bdsh = new BasicDataShare(tipMessages[i]);
                }
                else if (messagefields[0] == "BDDe")
                {
                    BasicDataDerivative bdde = new BasicDataDerivative(tipMessages[i]);
                }
                else if (messagefields[0] == "BDEt")
                {
                    BasicDataFund bdet = new BasicDataFund(tipMessages[i]);
                }
                else if (messagefields[0] == "BDRi")
                {
                    BasicDataRight bdri = new BasicDataRight(tipMessages[i]);
                }
                else if (messagefields[0] == "BDUi")
                {
                    BasicDataUnderlyingInfo bdui = new BasicDataUnderlyingInfo(tipMessages[i]);
                }
                else if (messagefields[0] == "m")
                {
                    OrderbookSummary m = new OrderbookSummary(tipMessages[i]);
                }
                else if (messagefields[0] == "BDLm")
                {
                    BasicDataListMember bdlm = new BasicDataListMember(tipMessages[i]);
                }
                else if (messagefields[0] == "BDSm")
                {
                    BasicDataSectorMember bdsm = new BasicDataSectorMember(tipMessages[i]);
                }
                else if (messagefields[0] == "EOBd")
                {
                    EndOfBasicData eobd = new EndOfBasicData(tipMessages[i]);
                }
                else if (messagefields[0] == "BDIn")
                {
                    BasicDataIndex bdin = new BasicDataIndex(tipMessages[i]);
                }
                else if (messagefields[0] == "BDIp")
                {
                    BasicDataIndexSupplementary bdip = new BasicDataIndexSupplementary(tipMessages[i]);
                }
                else if (messagefields[0] == "BDIm")
                {
                    BasicDataIndexMember bdim = new BasicDataIndexMember(tipMessages[i]);
                }
                else if (messagefields[0] == "Is")
                {
                    IndexSummary indexsum = new IndexSummary(tipMessages[i]);
                }
                else if (messagefields[0] == "Iw")
                {
                    IndexWeight indexw = new IndexWeight(tipMessages[i]);
                }
                else if (messagefields[0] == "TRh")
                {
                    CorporateAction trh = new CorporateAction(tipMessages[i]);
                }
                else if (messagefields[0] == "s")
                {
                    StateChange s = new StateChange(tipMessages[i]);
                }
                else if (messagefields[0] == "r")
                {
                    OrderbookReferencePrice r = new OrderbookReferencePrice(tipMessages[i]);
                }
                else if (messagefields[0] == "o")
                {
                    Orderbook1 o = new Orderbook1(tipMessages[i]);
                }
                else if (messagefields[0] == "p")
                {
                    Orderbook2 p = new Orderbook2(tipMessages[i]);
                }
                else if (messagefields[0] == "z")
                {
                    Orderbook3 z = new Orderbook3(tipMessages[i]);
                }
                else if (messagefields[0] == "u")
                {
                    TradeStatistics1 u = new TradeStatistics1(tipMessages[i]);
                }
                else if (messagefields[0] == "v")
                {
                    TradeStatistics2 v = new TradeStatistics2(tipMessages[i]);
                }
                else if (messagefields[0] == "w")
                {
                    TradeStatistics3 w = new TradeStatistics3(tipMessages[i]);
                }
                else if (messagefields[0] == "c")
                {
                    CallInformation1 c = new CallInformation1(tipMessages[i]);
                }
                else if (messagefields[0] == "Cl")
                {
                    CallInformation2 cl = new CallInformation2(tipMessages[i]);
                }
                else if (messagefields[0] == "k")
                {
                    MBPOrderSnapshot k = new MBPOrderSnapshot(tipMessages[i]);
                }
                else if (messagefields[0] == "t")
                {
                    Trade t = new Trade(tipMessages[i]);
                }
                else if (messagefields[0] == "l")
                {
                    TurnoverListUpdate l = new TurnoverListUpdate(tipMessages[i]);
                }
                else if (messagefields[0] == "i")
                {
                    IndexUpdate i1 = new IndexUpdate(tipMessages[i]);
                }
                else if (messagefields[0] == "q")
                {
                    MarketMakerQuote1 q = new MarketMakerQuote1(tipMessages[i]);
                }
                else if (messagefields[0] == "y")
                {
                    MarketMakerQuote2 y = new MarketMakerQuote2(tipMessages[i]);
                }
                else if (messagefields[0] == "n")
                {
                    News n = new News(tipMessages[i]);
                }
                else
                {
                    throw new Exception("Unknown TIP Message = " + tipMessages[i]);
                }
            }
        }
    }
}

