using InterviewTask.Domain.Core.Models;
using InterviewTask.Infrastructure.Business.Services;
using System;

namespace InterviewTask.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var productComparer = new ComparisonService();

            productComparer.Add(new BasicProduct());
            productComparer.Add(new PackagedProduct());

            // Task test data
            productComparer.CompareProducts(2000);
            productComparer.PrintProducts();

            productComparer.CompareProducts(3500);
            productComparer.PrintProducts();

            productComparer.CompareProducts(4500);
            productComparer.PrintProducts();

            productComparer.CompareProducts(6000);
            productComparer.PrintProducts();
        }
    }
}
