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
    class BasicDataListMemberTest
    {
        [Test]
        public void ParseBasicDataListMember()
        {
            string data = "BDLm;IDo410;LSi38;s1;";
            BasicDataListMember BDLm = new BasicDataListMember(data);
            Assert.AreEqual(410,BDLm.IDo);
            Assert.AreEqual(38,BDLm.LSi);
            Assert.AreEqual(1,BDLm.s);
        }
    }
}
