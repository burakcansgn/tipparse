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
    class BasicDataExchangeTest
    {
        [Test]
        public void ParseBasicDataExchange()
        {
            string data = "BDx;i6;Si080;s1;SYmXIST;NAmBorsa Istanbul;CNyTR;MIcXIST;";
            BasicDataExchange BDx = new BasicDataExchange(data);
            Assert.AreEqual(6, BDx.i);
            Assert.AreEqual("080", BDx.Si);
            Assert.AreEqual(1, BDx.s);
            Assert.AreEqual("XIST", BDx.SYm);
            Assert.AreEqual("Borsa Istanbul", BDx.NAm);
            Assert.AreEqual("TR", BDx.CNy);
            Assert.AreEqual("XIST", BDx.MIc);
        }
    }
}
