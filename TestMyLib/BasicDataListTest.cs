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
    class BasicDataListTest
    {
        [Test]
        public void generateclass12()
        {
            string data = "BDLi;i258;Si080160;s1;PAi8;SYmPDATA;NAmMARKET FOR EXTERNAL PRICE DATA;LCyTRY;TCeY;";
            BasicDataList BDLi = new BasicDataList(data);
            Assert.AreEqual(258,BDLi.i);
            Assert.AreEqual("080160", BDLi.Si);
            Assert.AreEqual(1, BDLi.s);
            Assert.AreEqual(8, BDLi.PAi);
            Assert.AreEqual("PDATA", BDLi.SYm);
            Assert.AreEqual("MARKET FOR EXTERNAL PRICE DATA", BDLi.NAm);
            Assert.AreEqual("TRY", BDLi.LCy);
            Assert.AreEqual(true, BDLi.TCe);
        }
    }
}
