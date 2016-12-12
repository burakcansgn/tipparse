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
    class TradeStatistics1Test
    {
        [Test]
        public void ParseTradeStatistics1()
        {
            TimeSpan t = new TimeSpan(0, 07, 02, 05, 164);
            string data = "u;i388;s1;t070205.164;Of;";
            TradeStatistics1 u = new TradeStatistics1(data);
            Assert.AreEqual(388, u.i);
            Assert.AreEqual(1, u.s);
            Assert.AreEqual(t, u.t);
            Assert.AreEqual(false, u.Of);
        }
        
    }
}
