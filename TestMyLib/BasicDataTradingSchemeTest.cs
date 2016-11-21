using NUnit.Framework;
using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TestMyLib
{
    [TestFixture]
    class BasicDataTradingSchemeTest
    {
        [Test]
         public void deneme()
        {
            string se = "20150730";
            DateTime dt = DateTime.ParseExact(se, "yyyyMMdd", CultureInfo.InvariantCulture);
        }
        [Test]
        public void generateclass11()
        {
            TimeSpan ts = new TimeSpan(0, 17, 40, 00, 000);
             DateTime t = new DateTime(2015, 07, 30);
             string data = "BDTm;s1;TRId96;SiP_SALT_SI;Dt20150730;Ms1;St174000.000;";
             BasicDataTradingScheme BDTm = new BasicDataTradingScheme(data);
             Assert.AreEqual(1, BDTm.s);
             Assert.AreEqual(96,BDTm.TRId);
             Assert.AreEqual("P_SALT_SI",BDTm.Si);
             Assert.AreEqual(t,BDTm.Dt);
             Assert.AreEqual("1", BDTm.Ms);
             Assert.AreEqual(ts,BDTm.St);
             
            
        }

    }
}
