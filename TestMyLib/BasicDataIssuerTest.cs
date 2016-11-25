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
    class BasicDataIssuerTest
    {
        [Test]
        public void generateclass15()
        {
            string data = "BDIs;i304;SiAFB;s1;SYmAFB;NAmAKTIF YATIRIM  BANKASI AS;CNyTR;";
            BasicDataIssuer BDs = new BasicDataIssuer(data);
            Assert.AreEqual(304, BDs.i);
            Assert.AreEqual("AFB", BDs.Si);
            Assert.AreEqual(1, BDs.s);
            Assert.AreEqual("AKTIF YATIRIM  BANKASI AS", BDs.NAm);
            Assert.AreEqual("TR", BDs.CNy);
            Assert.AreEqual("AFB", BDs.SYm);

        }
    }
}
