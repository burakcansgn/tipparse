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
    class NewsTest
    {
        [Test]
        public void ParseNews()
        {
            TimeSpan t = new TimeSpan(0, 14, 07, 05, 249);
            NOt mynot = NOt.Market;
            string data = "n;s1;i288;NWi1;t140705.249;NOt2;NMsBORSA_BASKANLIGI_DUYURUSU;NHlTest;TExCok yogun Islem yapildigi goruldu. Sozkonusu siralar gecici durdurmaya alindi.;BLi1;BLlY;";
            News n = new News(data);
            Assert.AreEqual(1, n.s);
            Assert.AreEqual(288, n.i);
            Assert.AreEqual(1, n.NWi);
            Assert.AreEqual(t, n.t);
            Assert.AreEqual(mynot, n.NOt);
            Assert.AreEqual("BORSA_BASKANLIGI_DUYURUSU", n.NMs);
            Assert.AreEqual("Test", n.NHl);
            Assert.AreEqual("Cok yogun Islem yapildigi goruldu. Sozkonusu siralar gecici durdurmaya alindi.", n.TEx);
            Assert.AreEqual(1, n.BLi);
            Assert.AreEqual(true, n.BLl);
        }

    }
}
