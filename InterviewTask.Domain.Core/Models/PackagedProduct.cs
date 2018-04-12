using System;
using InterviewTask.Common.Shared;
using InterviewTask.Domain.Core.Models.Abstract;

namespace InterviewTask.Domain.Core.Models
{
    public class PackagedProduct : IProduct
    {
        public string Name => ProductConsts.PackagedProductName;

        public decimal AnnualCosts { get; private set; }

        public void CalculateAnnualCosts(decimal consumption)
        {
            if (consumption < 0)
            {
                throw new ArgumentException("Consumption can not be less than zero.");
            }

            if (consumption > ProductConsts.PackagedProductLimit)
            {
                AnnualCosts = ProductConsts.PackagedProductBaseCosts
                         + (consumption - ProductConsts.PackagedProductLimit)
                         * ProductConsts.PackagedProductAdditionalCoefficient;
            }
            else
            {
                AnnualCosts = ProductConsts.PackagedProductBaseCosts;
            }
        }
    }
}
