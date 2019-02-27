using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;

namespace PracticeCodeMVC.Data.Entities
{
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifined { get; set; }
        public string Description { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public string SeoAlias { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeyWords { get; set; }
        public string SeoPageTitle { get; set; }
        public Status status { get; set; }
        public string Tags { get; set; }
        public decimal Unit { get; set; }
        public int? ViewCount { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}