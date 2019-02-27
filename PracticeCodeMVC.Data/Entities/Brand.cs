using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Brand : DomainEntity<int>, ISwitchable
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public Status status { get; set; }
    }
}
