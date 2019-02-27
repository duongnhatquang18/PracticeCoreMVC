using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class AdvertisementPage : DomainEntity<int>
    {
        public string Name { get; set; }
    }
}
