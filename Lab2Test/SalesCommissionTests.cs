
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2Library;

namespace Lab2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()] 
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ZeroQuotaTest()
        {

            //Act
            SalesCommission.PercentOfquota(1,0);

            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeSalesTest()
        {
            //Act
            SalesCommission.PercentOfquota(-5, 5);

            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void PercentTest()
        {
            //Act
            double expected = 1;
            double actual = SalesCommission.PercentOfquota(1, 1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]        
        public void Lt95Test()
        {            
            //Act
            double expected = 0;
            double actual = SalesCommission.Commissionrate(0.949);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Eq95Test()
        {            
            //Act
            double expected = 0.03;
            double actual = SalesCommission.Commissionrate(0.95);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Lt100Test()
        {            
            //Act
            double expected = 0.03;
            double actual = SalesCommission.Commissionrate(0.999);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Eq100Test()
        {
            //Arrange
            var target = new SalesCommission(100, 100);

            //Act
            double expected = 0.06;
            double actual = target.CommissionRate;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Lt120Test()
        {
            //Arrange
            var target = new SalesCommission(119.9, 100);

            //Act
            double notExpected = 0.10965;
            double actual = target.CommissionRate;

            //Assert
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod()]
        public void Gt120Test()
        {
            //Arrange
            var target = new SalesCommission(120.1, 100);

            //Act
            double notExpected = 0.11025;
            double actual = target.CommissionRate;

            //Assert
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod()]
        public void Lt150Test()
        {
            //Arrange
            var target = new SalesCommission(149.9, 100);

            //Act
            double notExtpected = 0.21445;
            double actual = target.CommissionRate;

            //Assert
            Assert.AreNotEqual(notExtpected, actual);
        }

        [TestMethod()]
        public void Gt150Test()
        {
            //Arrange
            var target = new SalesCommission(150.1, 100);

            //Act
            double notExtpected = 0.21535;
            double actual = target.CommissionRate;

            //Assert
            Assert.AreNotEqual(notExtpected, actual);

        }
    }    
}
