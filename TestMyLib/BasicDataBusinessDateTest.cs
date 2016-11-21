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
    class BasicDataBusinessDateTest
    {

        [Test]
        public void generateclass01()
        {
            DateTime t = new DateTime(2015, 07, 30);
            string data= "BDBu;Dt20150730;";
            BasicDataBusinessDate bdbd = new BasicDataBusinessDate(data);
            Assert.AreEqual (t,bdbd.date);

        }
    }
}
