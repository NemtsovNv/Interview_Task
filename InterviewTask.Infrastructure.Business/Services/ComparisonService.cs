using System;
using System.Collections.Generic;
using System.Linq;
using InterviewTask.Domain.Core.Models.Abstract;
using InterviewTask.Infrastructure.Business.Services.Abstract;

namespace InterviewTask.Infrastructure.Business.Services
{
    public class ComparisonService : IComaprisonService
    {
        public ComparisonService()
        {
            products = new List<IProduct>();
        }

        private List<IProduct> products;

        public void Add(IProduct product)
        {
            products.Add(product);
        }

        public IEnumerable<IProduct> CompareProducts(decimal consumption)
        {
            if (consumption < 0)
            {
                throw new ArgumentException("Argument can not be less than zero.", nameof(consumption));
            }

            foreach (var product in products)
            {
                product.CalculateAnnualCosts(consumption);
            }

            return products.OrderBy(product => product.AnnualCosts);
        }

        public void PrintProducts()
        {
            foreach(var product in products)
            {
                Console.WriteLine($"{ product.Name } : { product.AnnualCosts }");
            }
        }
    }
}
