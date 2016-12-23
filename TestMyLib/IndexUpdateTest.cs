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
    class IndexUpdateTest
    {
        [Test]
        public void ParseIndexUpdate()
        {
            TimeSpan t = new TimeSpan(0, 09, 35, 00, 000);
            string data = "i;i2600;s2;t093500.000;Vc99387.7509;Vh99387.7509;Vl99387.7509;o0;f0;OVa99387.7509;Dn0;Dd0;";
            IndexUpdate i = new IndexUpdate(data);
            Assert.AreEqual(2600,i.i);
            Assert.AreEqual(2,i.s);
            Assert.AreEqual(t,i.t);
            Assert.AreEqual(99387.7509,i.Vc);
            Assert.AreEqual(99387.7509,i.Vh);
            Assert.AreEqual(99387.7509,i.Vl);
            Assert.AreEqual(0,i.o);
            Assert.AreEqual(0,i.f);
            Assert.AreEqual(99387.7509,i.OVa);
            Assert.AreEqual(0,i.Dn);
            Assert.AreEqual(0, i.Dd);
        }
    }
}
