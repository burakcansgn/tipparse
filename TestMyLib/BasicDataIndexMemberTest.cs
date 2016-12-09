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
    class BasicDataIndexMemberTest
    {
        [Test]
        public void ParseBasicDataIndexMember()
        {
            string data = "BDIm;IDo388;IXi2548;s2;";
            BasicDataIndexMember BDIm = new BasicDataIndexMember(data);
            Assert.AreEqual(388,BDIm.IDo);
            Assert.AreEqual(2548,BDIm.IXi);
            Assert.AreEqual(2,BDIm.s);
        }
    }
}
