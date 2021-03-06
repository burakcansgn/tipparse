﻿using NUnit.Framework;
using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyLib
{
    [TestFixture]
    class BasicDataNonTradingDaysTest
    {
        [Test]
        public void ParseBasicDataNonTradingDays()
        {
            DateTime t = new DateTime(2015, 09, 23);
            string data = "BDTd;s1;i256;Si080160;Dt20150923;TDt2160;";
            BasicDataNonTradingDays BDTd = new BasicDataNonTradingDays(data);
            Assert.AreEqual(1,BDTd.s);
            Assert.AreEqual(256,BDTd.i);
            Assert.AreEqual("080160",BDTd.Si);
            Assert.AreEqual(t, BDTd.Dt);
            Assert.AreEqual(2160, BDTd.TDt);

        }
        
    }
}
