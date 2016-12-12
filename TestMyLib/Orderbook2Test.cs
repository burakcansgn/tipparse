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
            string data = "o;i388;s1;t070204.583;Of;";
            Orderbook1 o = new Orderbook1(data);
            Assert.AreEqual(388, o.i);
            Assert.AreEqual(1, o.s);
            Assert.AreEqual(t, o.t);
            Assert.AreEqual(false, o.Of);
        }
    }
}
