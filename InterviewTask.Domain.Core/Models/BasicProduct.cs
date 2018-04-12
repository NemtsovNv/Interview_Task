using System;
using InterviewTask.Common.Shared;
using InterviewTask.Domain.Core.Models.Abstract;

namespace InterviewTask.Domain.Core.Models
{
    public class BasicProduct : IProduct
    {
        public string Name => ProductConsts.BasicProductName;

        public decimal AnnualCosts { get; private set; }

        public void CalculateAnnualCosts(decimal consumption)
        {
            if (consumption < 0)
            {
                throw new ArgumentException("Consumption can not be less than zero.");
            }

            AnnualCosts = (ProductConsts.BasicProductBaseCosts * 12) +
                          (ProductConsts.BasicProductConsumptionCoefficient * consumption);
        }
    }
}
