﻿using PracticeCodeMVC.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Application.ViewModels.Product
{
    public class ProductCategoryViewModel
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

        public ICollection<ProductViewModel> Products { get; set; }
    }
}
