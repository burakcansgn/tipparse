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
        public void generateclass6()
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
    }
}
