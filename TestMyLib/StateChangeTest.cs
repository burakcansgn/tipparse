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
    class StateChangeTest
    {
        [Test]
        public void ParseStateChange()
        {
            TimeSpan t = new TimeSpan(0, 07, 02, 02);
            string data = "s;i260;s1;t070202.938;Ms99;Sl1;";
            StateChange s = new StateChange(data);
            Assert.AreEqual(260,s.i);
            Assert.AreEqual(1,s.s);
            Assert.AreEqual(t,s.t);
            Assert.AreEqual(1,s.Sl);

        }
    }
}
