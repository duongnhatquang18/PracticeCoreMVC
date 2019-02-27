﻿using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class ProductTag : DomainEntity<int>
    {
        public int ProductId { get; set; }
        public int TagId { get; set; }

        public virtual Product Product { set; get; }
        public virtual Tag Tag { set; get; }
    }
}
