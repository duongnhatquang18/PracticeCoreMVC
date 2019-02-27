using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class BlogTag : DomainEntity<int>
    {
        public int BlogId { get; set; }
        public int TagId { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
