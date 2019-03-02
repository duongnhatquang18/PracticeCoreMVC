using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Call save change from db context
        /// </summary>
        void Commit();
    }
}
