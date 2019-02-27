using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Language:DomainEntity<int>
    {
        public string Name { get; set; }
        public string Default { get; set; }
    }
}
