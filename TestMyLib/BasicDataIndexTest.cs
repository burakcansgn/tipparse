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
    class BasicDataIndexTest
    {
        [Test]
        public void ParseBasicDataIndex()
        {
            string data = "BDIn;i2548;SiXUTUM;s2;SYmXUTUM;NAmBIST TUM TRY;LCyTRY;POt2542;TYc2538;ITy2514;IPt2528;Is2506;Io2546;Di1;";
            BasicDataIndex BDIn = new BasicDataIndex(data);
            Assert.AreEqual(2548,BDIn.i);
            Assert.AreEqual("XUTUM",BDIn.Si);
            Assert.AreEqual(2,BDIn.s);
            Assert.AreEqual("XUTUM",BDIn.SYm);
            Assert.AreEqual("BIST TUM TRY",BDIn.NAm);
            Assert.AreEqual("TRY",BDIn.LCy);
            Assert.AreEqual(2542,BDIn.POt);
            Assert.AreEqual(2538,BDIn.TYc);
            Assert.AreEqual(2514,BDIn.ITy);
            Assert.AreEqual(2528,BDIn.IPt);
            Assert.AreEqual(2506,BDIn.Is);
            Assert.AreEqual(2546,BDIn.Io);
            Assert.AreEqual(1,BDIn.Di);


        }
    }
}
