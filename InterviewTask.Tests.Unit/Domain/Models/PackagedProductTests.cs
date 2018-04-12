using InterviewTask.Domain.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterviewTask.Tests.Unit.Domain.Models
{
    [TestClass]
    public class PackagedProductTests
    {
        [TestMethod]
        public void Name_Returns_Packaged_Name()
        {
            // Assert
            var expectedName = "Packaged tariff";

            // Act
            var product = new PackagedProduct();

            // Arrange
            Assert.IsNotNull(product);
            Assert.IsNotNull(product.Name);
            Assert.AreEqual(expectedName, product.Name);
        }

        [TestMethod]
        public void CalculateAnnualCosts_Returns_800()
        {
            // Assert
            var expectedAnnualCosts = 800;
            var validConsumption = 1000;
            var product = new PackagedProduct();

            // Act
            product.CalculateAnnualCosts(validConsumption);

            // Arrange
            Assert.IsNotNull(product);
            Assert.AreEqual(expectedAnnualCosts, product.AnnualCosts);
        }

        [TestMethod]
        public void CalculateAnnualCosts_Returns_1400()
        {
            // Assert
            var expectedAnnualCosts = 1400;
            var validConsumption = 6000;
            var product = new PackagedProduct();

            // Act
            product.CalculateAnnualCosts(validConsumption);

            // Arrange
            Assert.IsNotNull(product);
            Assert.AreEqual(expectedAnnualCosts, product.AnnualCosts);
        }

        [TestMethod]
        public void CalculateAnnualCosts_Returns_23600()
        {
            // Assert
            var expectedAnnualCosts = 23600;
            var validConsumption = 80000;
            var product = new PackagedProduct();

            // Act
            product.CalculateAnnualCosts(validConsumption);

            // Arrange
            Assert.IsNotNull(product);
            Assert.AreEqual(expectedAnnualCosts, product.AnnualCosts);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Consumption can not be less than zero.")]
        public void CalculateAnnualCosts_Throws_Argument_Exception_Less_Then_Zero()
        {
            // Assert
            var inValidConsumption = -1;
            var product = new PackagedProduct();

            // Act
            product.CalculateAnnualCosts(inValidConsumption);
        }
    }
}
