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
    class CorporateActionTest
    {
        [Test]
        public void ParseCorparateAction()
        {
            TimeSpan ts = new TimeSpan(0,07,02,02,881);
            string data = "TRh;i1288;s1;SRe1;NOc14;t070202.881;";
            CorporateAction TRh = new CorporateAction(data);
            Assert.AreEqual(1288,TRh.i);
            Assert.AreEqual(1,TRh.s);
            Assert.AreEqual(1,TRh.SRe);
            Assert.AreEqual(14,TRh.NOc);
            Assert.AreEqual(ts,TRh.t);
        }
    }
}
