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
    class MarketMakerQuote1Test
    {
        [Test]
        public void ParseMarketMakerQuote1()
        {
            TimeSpan t = new TimeSpan(0, 12, 05, 33, 162);
            string data = "q;i1706;s1;t120533.162;Pa2.75;Pb2.7;";
            MarketMakerQuote1 q = new MarketMakerQuote1(data);
            Assert.AreEqual(1706, q.i);
            Assert.AreEqual(1, q.s);
            Assert.AreEqual(t, q.t);
            Assert.AreEqual(2.75, q.Pa);
            Assert.AreEqual(2.7, q.Pb);
        }
    }
}
