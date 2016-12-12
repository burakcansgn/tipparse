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
    class CallInformation1Test
    {
        [Test]
        public void ParseCallInformation1()
        {
            TimeSpan t = new TimeSpan(0, 09, 17, 01, 680);
            string data = "c;i950;s1;t091701.680;EQp9.1;EQv36250;";
            CallInformation1 c = new CallInformation1(data);
            Assert.AreEqual(950,c.i);
            Assert.AreEqual(1,c.s);
            Assert.AreEqual(t,c.t);
            Assert.AreEqual(9.1,c.EQp);
            Assert.AreEqual(36250,c.EQv);
        }
    }
}
