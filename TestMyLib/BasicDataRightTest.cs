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
    class BasicDataRightTest
    {
        [Test]
        public void ParseBasicDataRight()
        {
            string data = "BDRi;i486;SiBURCE.R;s1;EXcTRY;";
            BasicDataRight BDRi = new BasicDataRight(data);
            Assert.AreEqual(486, BDRi.i);
            Assert.AreEqual("BURCE.R", BDRi.Si);
            Assert.AreEqual(1, BDRi.s);
            Assert.AreEqual("TRY", BDRi.EXc);

        }


    }
}
