using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class SystemConfig:DomainEntity<string>, ISwitchable
    {
        public string Name { get; set; }
        public string Value1 { get; set; }
        public int? Value2 { get; set; }
        public DateTime? Value3 { get; set; }
        public bool? Value4 { get; set; }
        public decimal? Value5 { get; set; }
        public Status Status { get; set; }
    }
}
