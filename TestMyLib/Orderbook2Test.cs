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
    class Orderbook2Test
    {
        [Test]
        public void ParseOrderbook2()
        {
            TimeSpan t = new TimeSpan(0, 07, 02, 04, 583);
            string data = "p;i388;s1;t070204.583;Of;";
            Orderbook2 p = new Orderbook2(data);
            Assert.AreEqual(388, p.i);
            Assert.AreEqual(1, p.s);
            Assert.AreEqual(t, p.t);
            Assert.AreEqual(false, p.Of);
        }
    }
}
