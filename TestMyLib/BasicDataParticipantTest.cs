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
    class BasicDataParticipantTest
    {
        [Test]
        public void ParseBasicDataParticipant()
        {
            string data = "BDp;i2166;SiBISOG;s1;SYmBISOG;NAmSOCIETE GENERALE ISTANBUL-TURKIYE MERKEZ SB;PAt2164;BIcSOGETRISXXX;GRsN;";
            BasicDataParticipant bdp = new BasicDataParticipant(data);
            Assert.AreEqual(2166,bdp.i);
            Assert.AreEqual("BISOG",bdp.Si);
            Assert.AreEqual(1,bdp.s);
            Assert.AreEqual("BISOG",bdp.SYm);
            Assert.AreEqual("SOCIETE GENERALE ISTANBUL-TURKIYE MERKEZ SB",bdp.NAm);
            Assert.AreEqual(2164,bdp.PAt);
            Assert.AreEqual("SOGETRISXXX",bdp.BIc);
            Assert.AreEqual(false,bdp.GRs);
        }
        [Test]
        public void ParseBasicDataParticipant2()
        {

            string data = "BDp;i2192;SiBIDSEC;s1;SYmBIDSEC;NAmDSEC;PAt2164;GRsN;";
            BasicDataParticipant bdp = new BasicDataParticipant(data);
            Assert.AreEqual(2192, bdp.i);
            Assert.AreEqual("BIDSEC", bdp.Si);
            Assert.AreEqual(1, bdp.s);
            Assert.AreEqual("BIDSEC", bdp.SYm);
            Assert.AreEqual("DSEC", bdp.NAm);
            Assert.AreEqual(2164, bdp.PAt);
            Assert.AreEqual(false, bdp.GRs);
        }
    }
}
