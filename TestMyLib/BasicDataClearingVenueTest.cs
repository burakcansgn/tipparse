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
    class BasicDataClearingVenueTest
    {
        [Test]
        public void generateclass07()
        {
            string data = "BDCv;i250;SiTVS;s1;SYmTVSBTRISXXX;NAmTAKASBANK;";
            BasicDataClearingVenue BDCv = new BasicDataClearingVenue(data);
            Assert.AreEqual(250,BDCv.i);
            Assert.AreEqual("TVS",BDCv.Si);
            Assert.AreEqual(1,BDCv.s);
            Assert.AreEqual("TVSBTRISXXX",BDCv.SYm);
            Assert.AreEqual("TAKASBANK",BDCv.NAm);
            
        }
    }
}
