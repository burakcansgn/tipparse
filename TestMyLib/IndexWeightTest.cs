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
    class IndexWeightTest
    {
        [Test]
        public void ParseIndexWeight()
        {
            SEd mysed = SEd.StartofDay;
            TimeSpan ts = new TimeSpan(0, 04, 10, 00, 000);
            string data = "Iw;i2550;s2;t041000.000;IDo1024;WPe0.224202;FFr0.44;Wf1;WFv341510400;CAp776160000;SEd1;";
            IndexWeight Iw = new IndexWeight(data);
            Assert.AreEqual(2550,Iw.i);
            Assert.AreEqual(2,Iw.s);
            Assert.AreEqual(ts,Iw.t);
            Assert.AreEqual(1024,Iw.IDo);
            Assert.AreEqual(0.224202,Iw.WPe);
            Assert.AreEqual(0.44,Iw.FFr);
            Assert.AreEqual(1,Iw.Wf);
            Assert.AreEqual(341510400,Iw.WFv);
            Assert.AreEqual(776160000,Iw.CAp);
            Assert.AreEqual(mysed,Iw.Sed);


        }
    }
}
