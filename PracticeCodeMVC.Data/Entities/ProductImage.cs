using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class ProductImage:DomainEntity<int>
    {
        public int ProductId { get; set; }
        public string Path { get; set; }
        public string Caption { get; set; }

        public virtual Product Product { get; set; }
    }
}
