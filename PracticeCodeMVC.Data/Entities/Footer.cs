using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Footer : DomainEntity<string>
    {
        public string Content { get; set; }
    }
}
