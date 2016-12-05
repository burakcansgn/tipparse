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
    class BasicDataUnderlyingInfoTest
    {
        [Test]
        public void ParseBasicDataUnderlyingInfo()
        {
            string data = @"BDUi;i396;SiGARIYMEPW999.MV;s1;DScGARAN ISSUER*\:IYM;";
            BasicDataUnderlyingInfo BDUi = new BasicDataUnderlyingInfo(data);
            Assert.AreEqual(396,BDUi.i);
            Assert.AreEqual("GARIYMEPW999.MV",BDUi.Si);
            Assert.AreEqual(1,BDUi.s);
            Assert.AreEqual(@"GARAN ISSUER*\:IYM",BDUi.DSc);
            
        }
    }
}
