using PracticeCodeMVC.Data.Entities;
using PracticeCodeMVC.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Application.ViewModels.Product
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        public string Tags { get; set; }
        public decimal Unit { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModifined { get; set; }
        public string SeoAlias { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeyWords { get; set; }
        public string SeoPageTitle { get; set; }
        public Status Status { get; set; }

        public ProductCategoryViewModel ProductCategory { get; set; }
    }
}
