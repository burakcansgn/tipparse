using MyLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyLib
{
    [TestFixture]
    class OrderbookSummaryTest
    {
        [Test]
        public void ParseOrderbookSummary()
        {
            DateTime d1 = new DateTime(2015,07,29);
            DateTime d2 = new DateTime(2015,07,14);
            DateTime d3 = new DateTime(2015,07,24);
            DateTime d4 = new DateTime(2015,01,13);
            DateTime d5 = new DateTime(2015,06,08);
            DateTime d6 = new DateTime(2015,07,28);
            TimeSpan ts = new TimeSpan(0, 17, 40, 00, 124);
            string data = "m;i388;s1;t174000.124;Dt20150729;ISOcY;ISOtY;Pl57.05;HPm65.5;HPMd20150714;LPm56;LPMd20150724;HPy96.7;HPYd20150113;LPy53.55;LPYd20150608;LPd20150728;";
            OrderbookSummary m = new OrderbookSummary(data);
            Assert.AreEqual(388,m.i);
            Assert.AreEqual(1,m.s);
            Assert.AreEqual(ts,m.t);
            Assert.AreEqual(d1,m.Dt);
            Assert.AreEqual(true,m.ISOc);
            Assert.AreEqual(true,m.ISOt);
            Assert.AreEqual(57.05,m.Pl);
            Assert.AreEqual(65.5,m.HPm);
            Assert.AreEqual(d2,m.HPMd);
            Assert.AreEqual(56,m.LPm);
            Assert.AreEqual(d3,m.LPMd);
            Assert.AreEqual(96.7,m.HPy);
            Assert.AreEqual(d4,m.HPYd);
            Assert.AreEqual(53.55f, m.LPy);
            Assert.AreEqual(d5,m.LPYd);
            Assert.AreEqual(d6,m.LPd);
        }

    }
}
