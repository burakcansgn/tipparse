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
    class OrderbookReferencePriceTest
    {
        [Test]
    public void ParseOrderbookReferencePrice()
        {
            TimeSpan t = new TimeSpan(0, 07, 02, 03, 192);
            string data = "r;s1;i672;t070203.192;RPr13.6;LPl10.88;UPl16.32;";
            OrderbookReferencePrice r = new OrderbookReferencePrice(data);
            Assert.AreEqual(1,r.s);
            Assert.AreEqual(672,r.i);
            Assert.AreEqual(t,r.t);
            Assert.AreEqual(13.6,r.RPr);
            Assert.AreEqual(10.88,r.LPl);
            Assert.AreEqual(16.32,r.UPl);
        }
           
    }
}
