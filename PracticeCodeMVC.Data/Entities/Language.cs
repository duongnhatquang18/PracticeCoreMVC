using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Language:DomainEntity<string>, ISwitchable
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public string Resources { get; set; }
        public Status status { get; set; }
    }
}
