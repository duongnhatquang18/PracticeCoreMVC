using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class AdvertisementPosition :DomainEntity<int>
    {
        public int PageId { get; set; }
        public string Name { get; set; }
    }
}
