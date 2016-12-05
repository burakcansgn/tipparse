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
    class BasicDataSectorMemberTest
    {
        [Test]
        public void ParseBasicDataSectorMember()
        {
            string data = "BDSm;IDo1288;SId128;s1;";
            BasicDataSectorMember BDSm = new BasicDataSectorMember(data);
            Assert.AreEqual(1288,BDSm.IDo);
            Assert.AreEqual(128,BDSm.SId);
            Assert.AreEqual(1,BDSm.s);
        }
    }
}
