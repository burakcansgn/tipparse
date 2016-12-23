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
    class TurnoverListUpdateTest
    {
        [Test]
        public void ParseTurnoverListUpdate()
        {
            TimeSpan t = new TimeSpan(0, 09, 30, 11, 876);
            string data = "l;i8;s1;t093011.876;f2170975;o146350;Bu885;Pu881;Pp3;Pm1;TNt11;";
            TurnoverListUpdate l = new TurnoverListUpdate(data);
            Assert.AreEqual(8,l.i);
            Assert.AreEqual(2170975,l.f);
            Assert.AreEqual(1,l.s);
            Assert.AreEqual(146350,l.o);
            Assert.AreEqual(885,l.Bu);
            Assert.AreEqual(881,l.Pu);
            Assert.AreEqual(3,l.Pp);
            Assert.AreEqual(1,l.Pm);
            Assert.AreEqual(11,l.TNt);
        }
    }
}
