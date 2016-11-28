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
    class BasicDataTradableTest
    {
        [Test]
        public void ParseBasicDataTradable()
        {
            DateTime t1 = new DateTime(2014, 04, 28);
            DateTime t2 = new DateTime(2015, 09, 23);
            string data = "BDt;i388;SiGOODY.E;s1;Mk288;INiMSPOTEQTGOODY;SYmGOODY.E;NAmGOODYEAR;ISi368;CUiTRY;CUtTRY;PRt1;VOd1;LDa20140428;ITSz78;NDp3;NDTp3;CNyTR;STy1;AUmY;TRaY;PTaY;PTb1;MSe56;LSz1;MLm1;MLt10000000;TRId100;TRmSM;GRsN;";
            BasicDataTradable BDt = new BasicDataTradable(data);
            Assert.AreEqual(388,BDt.i);
            Assert.AreEqual("GOODY.E", BDt.Si);
            Assert.AreEqual("GOODY.E", BDt.SYm);
            Assert.AreEqual(1, BDt.s);
            Assert.AreEqual(288, BDt.Mk);
            Assert.AreEqual("MSPOTEQTGOODY", BDt.INi);
            Assert.AreEqual("GOODYEAR", BDt.NAm);
            Assert.AreEqual(368, BDt.ISi);
            Assert.AreEqual("TRY", BDt.CUi);
            Assert.AreEqual("TRY", BDt.CUt);
            Assert.AreEqual(1, BDt.PRt);
            Assert.AreEqual(1, BDt.VOd);
            Assert.AreEqual(t1, BDt.LDa);
            Assert.AreEqual(78, BDt.ITSz);
            Assert.AreEqual(3, BDt.NDp);
            Assert.AreEqual(3, BDt.NDTp);
            Assert.AreEqual("TR", BDt.CNy);
            Assert.AreEqual(1, BDt.STy);
            Assert.AreEqual(true, BDt.AUm);
            Assert.AreEqual(true, BDt.TRa);
            Assert.AreEqual(true, BDt.PTa);
            Assert.AreEqual(1, BDt.PTb);
            Assert.AreEqual(56, BDt.MSe);
            Assert.AreEqual(1, BDt.LSz);
            Assert.AreEqual(1, BDt.MLm);
            Assert.AreEqual(10000000,BDt.MLt);
            Assert.AreEqual(100, BDt.TRId);
            Assert.AreEqual("SM", BDt.TRm);
            Assert.AreEqual(false, BDt.GRs);



        }
    }
}
