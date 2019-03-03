using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class AdvertisementPosition :DomainEntity<string>
    {
        public string PageId { get; set; }
        public string Name { get; set; }

        public virtual AdvertisementPage AdvertistmentPage { get; set; }

        public virtual ICollection<Advertisement> Advertistments { get; set; }
    }
}
