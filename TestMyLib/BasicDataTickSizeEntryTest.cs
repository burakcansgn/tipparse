using MyLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyLib
{
    [TestFixture]
    class BasicDataTickSizeEntryTest
    {
        [Test]
        public void generateclass05()
        {
            string data = "BDTz;i68;SiEQ_WR;s1;TSz0.001;PFr0.001;PTo999999.999;";
            BasicDataTickSizeEntry bdtz = new BasicDataTickSizeEntry(data);
            Assert.AreEqual(68, bdtz.i);
            Assert.AreEqual("EQ_WR", bdtz.Si);
            Assert.AreEqual(1, bdtz.s);
            Assert.AreEqual(0.001, bdtz.TSz);
            Assert.AreEqual(0.001, bdtz.PFr);
            Assert.AreEqual(999999.999, bdtz.PTo);
        }
    }
}