using InterviewTask.Domain.Core.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Infrastructure.Business.Services.Abstract
{
    public interface IComaprisonService
    {
        void Add(IProduct product);

        IEnumerable<IProduct> CompareProducts(decimal consumption);

        void PrintProducts();
    }
}
