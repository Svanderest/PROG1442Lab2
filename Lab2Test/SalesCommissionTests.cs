
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
        public void NegativeQuotaTest()
        {
            //Arrange
            var target = new SalesCommission(-1, -1);

            //Act
            double actual = target.PercentOfQuota;

            //Assert
            Assert.Fail();
        }

        [TestMethod()]        
        public void Lt95Test()
        {
            //Arrange
            var target = new SalesCommission(94.9, 100);

            //Act
            double expected = 0;
            double actual = target.CommissionRate;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Eq95Test()
        {
            //Arrange
            var target = new SalesCommission(95, 100);

            //Act
            double expected = 3;
            double actual = target.CommissionRate;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Lt100Test()
        {
            //Arrange
            var target = new SalesCommission(99.9, 100);

            //Act
            double expected = 3;
            double actual = target.CommissionRate;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Eq100Test()
        {
            //Arrange
            var target = new SalesCommission(100, 100);

            //Act
            double expected = 6;
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
            double notExpected = 10.965;
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
            double notExpected = 11.025;
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
            double notExtpected = 21.445;
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
            double notExtpected = 21.535;
            double actual = target.CommissionRate;

            //Assert
            Assert.AreNotEqual(notExtpected, actual);

        }
    }    
}
