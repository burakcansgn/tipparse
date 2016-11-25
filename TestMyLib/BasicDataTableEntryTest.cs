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
    class BasicDataTableEntryTest
    {

        [Test]
        public void ParseBasicDataTableEntry()
        {
            string data = "BDTe;i22;Si01;s1;TEt2;SYm01;NAmR.H. Kullandirilarak Bedelli Sermaye Art;";
            BasicDataTableEntry bdte = new BasicDataTableEntry(data);
            Assert.AreEqual(22,bdte.i);
            Assert.AreEqual("01",bdte.Si);
            Assert.AreEqual(1,bdte.s);
            Assert.AreEqual(2,bdte.TEt);
            Assert.AreEqual("01",bdte.SYm);
            Assert.AreEqual("R.H. Kullandirilarak Bedelli Sermaye Art", bdte.NAm);


        }


    }
}
