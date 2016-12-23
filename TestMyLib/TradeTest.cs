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
    class TradeTest
    {
        [Test]
        public void ParseTrade()
        {
            TimeSpan t1 = new TimeSpan(0, 09, 30, 00, 409);
            TimeSpan t2 = new TimeSpan(0, 09, 30, 00, 409);
            string data = "t;i950;s1;Tn1;t093000.409;TDi093000.409;p9.02;v10000;UlY;UhY;UvY;LtY;TiCSTWgQAAAAEAAAAA;";
            Trade t = new Trade(data);
            Assert.AreEqual(950,t.i);
            Assert.AreEqual(1,t.s);
            Assert.AreEqual(1,t.Tn);
            Assert.AreEqual(t1,t.t);
            Assert.AreEqual(t2,t.TDi);
            Assert.AreEqual(9.02,t.p);
            Assert.AreEqual(10000,t.v);
            Assert.AreEqual(true,t.Ul);
            Assert.AreEqual(true, t.Uv);
            Assert.AreEqual(true, t.Uh);
            Assert.AreEqual(true, t.Lt);
            Assert.AreEqual("CSTWgQAAAAEAAAAA",t.Ti);
            


        }
    }
}
