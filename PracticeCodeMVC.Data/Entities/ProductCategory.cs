using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeCodeMVC.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModifined { get; set; }
        public string SeoAlias { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeyWords { get; set; }
        public string SeoPageTitle { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}