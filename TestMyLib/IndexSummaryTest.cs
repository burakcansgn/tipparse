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
    class IndexSummaryTest
    {
        [Test]
        public void ParseIndexSummary()
        {
            SEd mysed = SEd.StartofDay;
            TimeSpan ts = new TimeSpan(0, 04, 10, 00, 000);
            string data = "Is;i2550;s2;t041000.000;o0;f0;ODXv78322.7848;IXDv1944808.183487;Dn0;Dd0;CAp152322792848.566803;SEd1;";
            IndexSummary Is = new IndexSummary(data);
            Assert.AreEqual(2550, Is.i);
            Assert.AreEqual(2, Is.s);
            Assert.AreEqual(ts, Is.t);
            Assert.AreEqual(0, Is.o);
            Assert.AreEqual(0, Is.f);
            Assert.AreEqual(78322.7848, Is.ODXv);
            Assert.AreEqual(1944808.183487, Is.IXDv);
            Assert.AreEqual(0, Is.Dn);
            Assert.AreEqual(0, Is.Dd);
            Assert.AreEqual(152322792848.566803, Is.CAp);
            Assert.AreEqual(mysed, Is.Sed);
        }
    }
}
