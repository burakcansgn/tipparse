using MyLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyLib
{   [TestFixture]
    class BasicDataFundTest
    {
       [Test]
       public void ParseBasicDataFund()
        {
            string data = "BDEt;i566;SiSLVRP.F;s1;";
            BasicDataFund BDEt = new BasicDataFund(data);
            Assert.AreEqual(566,BDEt.i);
            Assert.AreEqual("SLVRP.F",BDEt.Si);
            Assert.AreEqual(1,BDEt.s);
        }
    }
}
