using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheRepository.ViewModel;

namespace TheRepository.Test
{
    [TestClass]
    public class MyFirstTestClass
    {
        [TestMethod]
        public void MyFirstTestMethode()
        {
            //1. Arrange
            var car = new CarVM(new Car { Prijs = 134, Bijtelling = 14 });
            var expected = 134 / 14 * 2;
            
            //2. Act
            var result = car.LeaseKostenPerMaand;

            //3. Assert
            Assert.AreEqual(expected, result);
        }


    }

}
