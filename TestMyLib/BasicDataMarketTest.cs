using NUnit.Framework;
using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyLib
{
    [TestFixture]

    class BasicDataMarketTest
    {
        [Test]
        public void generateclass9()
        {
            string data = "BDm;i252;Si255254;s1;Ex10;NAmINTEREST RATE MARKET;SYmINTRT;TOTa+0300;LDa20140826;";
            BasicDataMarket BDm = new BasicDataMarket(data);
            Assert.AreEqual(252, BDm.i);
            Assert.AreEqual("255254", BDm.Si);
            Assert.AreEqual(1, BDm.s);
            Assert.AreEqual(10, BDm.Ex);
            Assert.AreEqual("INTEREST RATE MARKET", BDm.NAm);
            Assert.AreEqual("INTRT", BDm.SYm);
            Assert.AreEqual("+0300", BDm.TOTa);
            Assert.AreEqual("20140826", BDm.LDa);
            Assert.AreEqual("", BDm.TTd);
        }
       
    }
}
