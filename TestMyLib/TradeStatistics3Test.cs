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
    class TradeStatistics3Test
    {
        [Test]
        public void ParseTradeStatistics3()
        {
            TimeSpan t = new TimeSpan(0, 07, 02, 05, 164);
            string data = "w;i388;s1;t070205.164;Of;";
            TradeStatistics3 w = new TradeStatistics3(data);
            Assert.AreEqual(388, w.i);
            Assert.AreEqual(1, w.s);
            Assert.AreEqual(t, w.t);
            Assert.AreEqual(false, w.Of);
        }
    }
}
