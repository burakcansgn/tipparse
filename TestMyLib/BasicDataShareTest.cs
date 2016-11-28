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
    class BasicDataShareTest
    {
        [Test]
        public void ParseBasicDataShare()
        {
            DateTime t1 = new DateTime(2014,11,12);
            DateTime t2 = new DateTime(2014, 11, 14);
            string data = "BDSh;i844;SiYKBNK.HE;s1;AVq50000;As20141112;Ae20141114;"; 
            BasicDataShare BDSh = new BasicDataShare(data);
            Assert.AreEqual(844,BDSh.i);
            Assert.AreEqual("YKBNK.HE",BDSh.Si);
            Assert.AreEqual(1,BDSh.s);
            Assert.AreEqual(50000,BDSh.AVq);
            Assert.AreEqual(t1,BDSh.As);
            Assert.AreEqual(t2, BDSh.Ae);
        }
    }
}
