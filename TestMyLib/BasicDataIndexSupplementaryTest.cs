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
    class BasicDataIndexSupplementaryTest
    {
        [Test]
        public void ParseBasicDataIndexSupplementary()
        {
            string data = "BDIp;i2548;SiXUTUM;s2;ISnTRAIMKB00044;";
            BasicDataIndexSupplementary BDIp = new BasicDataIndexSupplementary(data);
            Assert.AreEqual(2548, BDIp.i);
            Assert.AreEqual("XUTUM", BDIp.Si);
            Assert.AreEqual("TRAIMKB00044", BDIp.ISn);

        }
    }
}
