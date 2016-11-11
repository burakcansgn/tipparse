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
        public void generateclass2()
        {

            string name = "BDSr;i1;NAmGITS;";
            BasicDataSource bds = new BasicDataSource(name);
            Assert.AreEqual(1, bds.Source2);
            Assert.AreEqual("GITS", bds.Source);

        }
    }
    }


