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
    class TradeStatistics2Test
    {
        [Test]
        public void ParseTradeStatistics2()
        {
            TimeSpan t = new TimeSpan(0, 07, 02, 05, 164);
            string data = "v;i388;s1;t070205.164;Of;";
            TradeStatistics2 v = new TradeStatistics2(data);
            Assert.AreEqual(388, v.i);
            Assert.AreEqual(1, v.s);
            Assert.AreEqual(t, v.t);
            Assert.AreEqual(false, v.Of);
        }
    }
}
