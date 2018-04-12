namespace InterviewTask.Domain.Core.Models.Abstract
{
    public interface IProduct
    {
        string Name { get; }

        decimal AnnualCosts { get; }

        void CalculateAnnualCosts(decimal consumption);
    }
}
