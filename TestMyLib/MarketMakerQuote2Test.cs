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
    class MarketMakerQuote2Test
    {
        [Test]
        public void ParseMarketQuote2()
        {
            TimeSpan t = new TimeSpan(0, 12, 05, 33, 162);
            string data = "y;i1706;s1;t120533.162;Pa2.75;Pb2.7;Vb250;Va750;";
            MarketMakerQuote2 y = new MarketMakerQuote2(data);
            Assert.AreEqual(1706, y.i);
            Assert.AreEqual(1, y.s);
            Assert.AreEqual(t, y.t);
            Assert.AreEqual(2.75, y.Pa);
            Assert.AreEqual(2.7, y.Pb);
            Assert.AreEqual(250, y.Vb);
            Assert.AreEqual(750, y.Va);
        }

    }
}
