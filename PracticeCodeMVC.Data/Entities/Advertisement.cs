using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Advertisement :DomainEntity<int>, ISwitchable, ISortable, IDateTracking
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PositionId { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public Status Status { get; set; }
        public int SortOrder { get; set;}
        public DateTime DateCreated { get; set;}
        public DateTime DateModifined { get; set;}

        public virtual AdvertisementPosition AdvertistmentPosition { get; set; }
    }
}
