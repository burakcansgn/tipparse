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
    class BasicDataTickSizeTableTest
    {
        [Test]
        public void generateclass4()
        {
            string data = "BDTs;i68;SiEQ_WR;s1;NAmEQ_WR;";
            BasicDataTickSizeTable bdts = new BasicDataTickSizeTable(data);
            Assert.AreEqual(68,bdts.id);
            Assert.AreEqual("EQ_WR",bdts.si);
            Assert.AreEqual(1,bdts.s);
            Assert.AreEqual("Q_WR",bdts.nm);
        }
    }
}
