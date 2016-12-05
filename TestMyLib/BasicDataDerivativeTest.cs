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
    class BasicDataDerivativeTest
    {
        [Test]
       public void ParseBasicDataDerivative()
        {
            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime(2064,07,14);
            DateTime d3 = new DateTime();
            string data = "BDDe;i518;SiGARDBLSCR555;s1;DTy2;DXt4;CSz1;SEt1;EXe20640714;";
            BasicDataDerivative BDDe = new BasicDataDerivative(data);
            Assert.AreEqual(518,BDDe.i);
            Assert.AreEqual("GARDBLSCR555",BDDe.Si);
            Assert.AreEqual(1,BDDe.s);
            Assert.AreEqual(2,BDDe.DTy);
            Assert.AreEqual(4,BDDe.DXt);
            Assert.AreEqual(1,BDDe.CSz);
            Assert.AreEqual(1,BDDe.SEt);
            Assert.AreEqual(d2,BDDe.EXe);
        }
    }
}
