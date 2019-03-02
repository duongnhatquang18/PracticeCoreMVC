using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Page : DomainEntity<int>,ISwitchable
    {
        public string Name { get; set; }
        public string Alias { set; get; }
        public string Content { get; set; }
        public Status Status { get; set; }
    }
}
