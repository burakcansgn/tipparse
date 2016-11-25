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
        class BasicDataSourceTest
        {
         [Test]
        public void ParseBasicDataSource()
        {

            string data = "BDSr;i1;NAmGITS;";
            BasicDataSource bds = new BasicDataSource(data);
            Assert.AreEqual(1, bds.i);
            Assert.AreEqual("GITS", bds.NAm);

        }
    }
    }


