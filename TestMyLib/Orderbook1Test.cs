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
    class Orderbook1Test
    {
        [Test]
        public void ParseOrderbook1()
        {
            TimeSpan t = new TimeSpan(0, 07, 02, 04, 583);
            string data = "o;i388;s1;t070204.583;Of;";
            Orderbook1 o = new Orderbook1(data);
            Assert.AreEqual(388, o.i);
            Assert.AreEqual(1, o.s);
            Assert.AreEqual(t, o.t);
            Assert.AreEqual(false, o.Of);
        }

        [Test]
        public void ParseOrderbook11()
        {
            List<bTuple> btuplelist = new List<bTuple>() { new bTuple(1, 0.96m), new bTuple(2, 0.92m), new bTuple(3, 0.88m), new bTuple(4, 0.86m) };
            TimeSpan t = new TimeSpan(0, 09, 29, 59, 751);
            string data = "o;i1664;s1;t092959.751;b1:0.96;b2:0.92;b3:0.88;b4:0.86;";
            Orderbook1 o = new Orderbook1(data);
            Assert.AreEqual(1664, o.i);
            Assert.AreEqual(1, o.s);
            Assert.AreEqual(t, o.t);
           
        }
    }
}
