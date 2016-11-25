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
    class BasicDataSectorTest
    {
        [Test]
        public void ParseBasicDataSector()
        {
            string data = "BDs;i128;Si1410;s1;NAmGAYRIMENKUL FAALIYETLERI;CDLv1;";
            BasicDataSector BDs = new BasicDataSector(data);
            Assert.AreEqual(128, BDs.i);
            Assert.AreEqual("1410", BDs.Si);
            Assert.AreEqual(1, BDs.s);
            Assert.AreEqual("GAYRIMENKUL FAALIYETLERI", BDs.NAm);
            Assert.AreEqual(1, BDs.CDLv);


        }
        [Test]
        public void ParseBasicDataSector2()
        {
            string data = "BDs;PAi8;i128;Si1410;s1;NAmGAYRIMENKUL FAALIYETLERI;SYmq;CDLv1;";
            BasicDataSector BDs = new BasicDataSector(data);
            Assert.AreEqual(128, BDs.i);
            Assert.AreEqual("1410", BDs.Si);
            Assert.AreEqual(1, BDs.s);
            Assert.AreEqual("GAYRIMENKUL FAALIYETLERI", BDs.NAm);
            Assert.AreEqual(1, BDs.CDLv);
            Assert.AreEqual("q", BDs.SYm);
            Assert.AreEqual(8, BDs.PAi);
        }
    }
}
