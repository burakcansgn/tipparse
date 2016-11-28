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
    class BasicDataTradableSupplementaryTest
    {
        [Test]
        public void ParseBasicDataTradableSupplementary()
        {
            string data = "BDTr;i388;SiGOODY.E;s1;ISnTRAGOODY91E9;";
            BasicDataTradableSupplementary BDTr = new BasicDataTradableSupplementary(data);
            Assert.AreEqual(388,BDTr.i);
            Assert.AreEqual("GOODY.E",BDTr.Si);
            Assert.AreEqual(1,BDTr.s);
            Assert.AreEqual("TRAGOODY91E9",BDTr.ISn);
        }
    }
}
