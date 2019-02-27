using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeCodeMVC.Data.Entities
{
    public class Blog : DomainEntity<int>, IDateTracking, IHasSeoMetaData, ISwitchable
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }
        public Status status { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeyWords { get; set; }
        public string SeoDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifined { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}