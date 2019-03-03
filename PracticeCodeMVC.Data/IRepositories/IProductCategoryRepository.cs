using PracticeCodeMVC.Data.Entities;
using PracticeCodeMVC.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory,int>
    {
    }
}
