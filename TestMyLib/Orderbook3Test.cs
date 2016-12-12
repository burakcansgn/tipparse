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
    class Orderbook3Test
    {
        [Test]
        public void ParseOrderbook3()
        {
            TimeSpan t = new TimeSpan(0, 07, 02, 04, 583);
            string data = "z;i388;s1;t070204.583;Of;";
            Orderbook3 z = new Orderbook3(data);
            Assert.AreEqual(388, z.i);
            Assert.AreEqual(1, z.s);
            Assert.AreEqual(t, z.t);
            Assert.AreEqual(false, z.Of);
        }
    }
}
