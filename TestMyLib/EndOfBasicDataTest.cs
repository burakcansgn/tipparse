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
    class EndOfBasicDataTest
    {
        [Test]
        public void ParseEndOfBasicData()
        {
            string data = "EOBd;s1;";
            EndOfBasicData EOBd = new EndOfBasicData(data);
            Assert.AreEqual(1, EOBd.s);

        }
    }
}
