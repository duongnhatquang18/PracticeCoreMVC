using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Color:DomainEntity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual BillDetail BillDetail { get; set; }

        public virtual ProductQuantity ProductQuantity { get; set; }
    }
}
