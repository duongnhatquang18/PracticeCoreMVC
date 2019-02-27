using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Footer : DomainEntity<int>
    {
        public string Content { get; set; }
    }
}
