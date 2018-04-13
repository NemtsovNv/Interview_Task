using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewTask.Domain.Core.Models;

namespace InterviewTask.Tests.Unit.Domian.Models
{
    [TestClass]
    public class BasicProductTests
    {
        [TestMethod]
        public void Name_Returns_Basic_Name()
        {
            // Assert
            var expectedName = "basic electricity tariff";

            // Act
            var product = new BasicProduct();

            // Arrange
            Assert.IsNotNull(product);
            Assert.IsNotNull(product.Name);
            Assert.AreEqual(expectedName, product.Name);
        }

        [TestMethod]
        public void CalculateAnnualCosts_Returns_280()
        {
            // Assert
            var expectedAnnualCosts = 280;
            var validConsumption = 1000;
            var product = new BasicProduct();

            // Act
            product.CalculateAnnualCosts(validConsumption);

            // Arrange
            Assert.IsNotNull(product);
            Assert.AreEqual(expectedAnnualCosts, product.AnnualCosts);
        }

        [TestMethod]
        public void CalculateAnnualCosts_Returns_1600()
        {
            // Assert
            var expectedAnnualCosts = 1600;
            var validConsumption = 7000;
            var product = new BasicProduct();

            // Act
            product.CalculateAnnualCosts(validConsumption);

            // Arrange
            Assert.IsNotNull(product);
            Assert.AreEqual(expectedAnnualCosts, product.AnnualCosts);
        }

        [TestMethod]
        public void CalculateAnnualCosts_Returns_22060()
        {
            // Assert
            var expectedAnnualCosts = 22060;
            var validConsumption = 100000;
            var product = new BasicProduct();

            // Act
            product.CalculateAnnualCosts(validConsumption);

            // Arrange
            Assert.IsNotNull(product);
            Assert.AreEqual(expectedAnnualCosts, product.AnnualCosts);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Argument can not be less than zero.")]
        public void CalculateAnnualCosts_Throws_Argument_Exception_Less_Then_Zero()
        {
            // Assert
            var inValidConsumption = -1;
            var product = new BasicProduct();

            // Act
            product.CalculateAnnualCosts(inValidConsumption);
        }
    }
}
