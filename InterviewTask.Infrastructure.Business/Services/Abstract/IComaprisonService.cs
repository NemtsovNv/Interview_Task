using System.Collections.Generic;
using InterviewTask.Domain.Core.Models.Abstract;

namespace InterviewTask.Infrastructure.Business.Services.Abstract
{
    public interface IComaprisonService
    {
        void Add(IProduct product);

        IEnumerable<IProduct> CompareProducts(decimal consumption);

        void PrintProducts();
    }
}
