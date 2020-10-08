using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorisk_opgave1;

namespace Opgave1_Unittest
{
    [TestClass]
    public class FanOutputTest
    {

        private FanOutput _asd;

        [TestInitialize]
        public void Init()
        {
            _asd = new FanOutput(0, "T", 20, 40);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NavnTest()
        {

            FanOutput navnTest = new FanOutput();

            navnTest.Name = "T";

            Assert.AreEqual("T", navnTest.Name);
        }

        [TestMethod]
        public void NavnTest2()
        {
            
            FanOutput navnTest = new FanOutput();

            navnTest.Name = "Taa";

            Assert.AreEqual("Taa", navnTest.Name);
        }

        [TestMethod]
        public void TempTest()
        {

            FanOutput tempTest = new FanOutput();

            tempTest.Temp = 15;

            Assert.AreEqual(15,tempTest.Temp);
        }

        [TestMethod]
        public void TempTest2()
        {

            FanOutput tempTest = new FanOutput();

            tempTest.Temp = 25;

            Assert.AreEqual(25, tempTest.Temp);
        }

        [TestMethod]
        public void TempTest3()
        {

            FanOutput tempTest = new FanOutput();

            tempTest.Temp = 20;

            Assert.AreEqual(20, tempTest.Temp);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TempTest4()
        {

            FanOutput tempTest = new FanOutput();

            tempTest.Temp = 30;

            Assert.AreEqual(30, tempTest.Temp);
        }

        [TestMethod]
        public void FugtTest()
        {

            FanOutput fugtest = new FanOutput();

            fugtest.Fugt = 30;

            Assert.AreEqual(30, fugtest.Fugt);
        }

        [TestMethod]
        public void FugtTest2()
        {

            FanOutput fugtest = new FanOutput();

            fugtest.Fugt = 80;

            Assert.AreEqual(80, fugtest.Fugt);
        }

        [TestMethod]
        public void FugtTest3()
        {

            FanOutput fugtest = new FanOutput();

            fugtest.Fugt = 60;

            Assert.AreEqual(60, fugtest.Fugt);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FugtTest4()
        {

            FanOutput fugtest = new FanOutput();

            fugtest.Fugt = 100;

            Assert.AreEqual(100, fugtest.Fugt);
        }

    }
}
