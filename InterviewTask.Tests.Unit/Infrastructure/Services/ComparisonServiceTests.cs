using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewTask.Domain.Core.Models;
using InterviewTask.Domain.Core.Models.Abstract;
using InterviewTask.Infrastructure.Business.Services;

namespace InterviewTask.Tests.Unit.Infrastructure.Services
{
    [TestClass]
    public class ComparisonServiceTests
    {
        [TestMethod]
        public void Add_Should_Add_Product()
        {
            // Arrange
            var comparisonService = new ComparisonService();
            var product = new BasicProduct();

            // Act
            try
            {
                comparisonService.Add(product);
            }
            catch(Exception ex)
            {
                Assert.Fail($"Throwed an exception during adding process. Exception message: {ex.Message}");
            }
        }

        [TestMethod]
        public void Print_Should_Not_Throw_Exception()
        {
            // Arrange
            var basicProduct = new BasicProduct();
            var packagedProduct = new PackagedProduct();
            var comparisonService = new ComparisonService();

            comparisonService.Add(basicProduct);
            comparisonService.Add(packagedProduct);

            // Act
            try
            {
                comparisonService.PrintProducts();
            }
            catch(Exception ex)
            {
                Assert.Fail($"Print function has thrown an exception. Exception message: {ex.Message}");
            }
        }

        [TestMethod]
        public void CompareProducts_Returns_Valid_Comparison_First_Packaged_Product()
        {
            // Arrange
            var basicProduct = new BasicProduct();
            var packagedProduct = new PackagedProduct();
            var comparisonService = new ComparisonService();
            var validConsumption = 5000;
            var expectedResultCount = 2;

            var expectedResult = new List<IProduct>()
            {
                packagedProduct,
                basicProduct
            };

            comparisonService.Add(basicProduct);
            comparisonService.Add(packagedProduct);

            // Act
            var actualResult = comparisonService.CompareProducts(validConsumption);

            // Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResultCount, actualResult.Count());
            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));
        }

        [TestMethod]
        public void CompareProducts_Returns_Valid_Comparison_First_Basic_Product()
        {
            // Arrange
            var basicProduct = new BasicProduct();
            var packagedProduct = new PackagedProduct();
            var comparisonService = new ComparisonService();
            var validConsumption = 3000;
            var expectedResultCount = 2;

            var expectedResult = new List<IProduct>()
            {
                basicProduct,
                packagedProduct
            };

            comparisonService.Add(basicProduct);
            comparisonService.Add(packagedProduct);

            // Act
            var actualResult = comparisonService.CompareProducts(validConsumption);

            // Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResultCount, actualResult.Count());
            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Argument can not be less than zero.")]
        public void CompareProducts_Throws_Argument_Exception_Less_Then_Zero()
        {
            // Arrange
            var basicProduct = new BasicProduct();
            var packagedProduct = new PackagedProduct();
            var comparisonService = new ComparisonService();
            var inValidConsumption = -1;

            comparisonService.Add(basicProduct);
            comparisonService.Add(packagedProduct);

            // Act
            var actualResult = comparisonService.CompareProducts(inValidConsumption);
        }
    }
}
