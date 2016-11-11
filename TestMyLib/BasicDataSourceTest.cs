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
            public void generateclass()
            {
                string osman = "BDSr;i1;NAmGITS;";
                BasicDataSource bds = new BasicDataSource(osman);
                Assert.AreEqual("GITS", bds.Source);

            }
        }
    }


