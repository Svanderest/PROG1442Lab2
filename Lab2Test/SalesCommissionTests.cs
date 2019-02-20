
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
            SalesCommission.PercentOfQuota(1,0);

            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeSalesTest()
        {
            //Act
            SalesCommission.PercentOfQuota(-5, 5);

            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void PercentTest()
        {
            //Act
            double expected = 1;
            double actual = SalesCommission.PercentOfQuota(1, 1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]        
        public void Lt95Test()
        {            
            //Act
            double expected = 0;
            double actual = SalesCommission.CommissionRate(0.949);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Eq95Test()
        {            
            //Act
            double expected = 0.03;
            double actual = SalesCommission.CommissionRate(0.95);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Lt100Test()
        {            
            //Act
            double expected = 0.03;
            double actual = SalesCommission.CommissionRate(0.999);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Eq100Test()
        {

            //Act
            double expected = 0.06;
            double actual = SalesCommission.CommissionRate(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Lt120Test()
        {                    
            //Act
            double expected = 0.10975;
            double actual = SalesCommission.CommissionRate(1.199);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Gt120Test()
        {            
            //Act
            double expected = 0.11035;
            double actual = SalesCommission.CommissionRate(1.201);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Lt150Test()
        {
            //Act
            double expected= 0.21465;
            double actual = SalesCommission.CommissionRate(1.499);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        public void Gt150Test()
        {           
            //Act
            double expected = 0.21545;
            double actual = SalesCommission.CommissionRate(1.501);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }    
}
