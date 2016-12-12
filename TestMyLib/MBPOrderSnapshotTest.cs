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
    class MBPOrderSnapshotTest
    {
        [Test]
        public void ParseMBPOrderSnapshot()
        {
            List<RBpTuple> rbptuplelist = new List<RBpTuple>() { new RBpTuple(1, 0.96m), new RBpTuple(2, 0.92m), new RBpTuple(3, 0.88m), new RBpTuple(4, 0.86m) };
            List<RBvTuple> rbvtuplelist = new List<RBvTuple>() { new RBvTuple(1, 300), new RBvTuple(2, 400), new RBvTuple(3, 200), new RBvTuple(4, 100) };
            TimeSpan t = new TimeSpan(0, 09, 29, 59, 763);
            string data = "k;s1;i1664;t092959.763;RBp1:0.96;RBv1:300;RBp2:0.92;RBv2:400;RBp3:0.88;RBv3:200;RBp4:0.86;RBv4:100;";
            MBPOrderSnapshot k = new MBPOrderSnapshot(data);

            Assert.AreEqual(1, k.s);
            Assert.AreEqual(1664, k.i);
            Assert.AreEqual(t, k.t);
            for (int i = 0; i < rbptuplelist.Count; i++)
            {
                Assert.AreEqual(rbptuplelist[i].RBpInt, k.RBptuple[i].RBpInt);
                Assert.AreEqual(rbptuplelist[i].RBpDecimal, k.RBptuple[i].RBpDecimal);
            }
            for (int j = 0; j < rbvtuplelist.Count; j++)
            {
                Assert.AreEqual(rbvtuplelist[j].RBvInt, k.RBvtuple[j].RBvInt);
                Assert.AreEqual(rbvtuplelist[j].RBvDecimal, k.RBvtuple[j].RBvDecimal);
            }

        }
    }
}
