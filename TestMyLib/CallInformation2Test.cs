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
    class CallInformation2Test
    {
        [Test]
        public void ParseCallformation2()
        {
            TimeSpan t = new TimeSpan(0, 09, 17, 01, 680);
            string data = "Cl;i950;s1;t091701.680;EQp9.1;EQv36250;EBv0;EAv63750;";
            CallInformation2 Cl = new CallInformation2(data);
            Assert.AreEqual(950, Cl.i);
            Assert.AreEqual(1, Cl.s);
            Assert.AreEqual(t, Cl.t);
            Assert.AreEqual(9.1, Cl.EQp);
            Assert.AreEqual(36250, Cl.EQv);
            Assert.AreEqual(0, Cl.EBv);
            Assert.AreEqual(63750, Cl.EAv);
        }
    }
}
