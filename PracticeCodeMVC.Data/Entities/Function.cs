using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Function : DomainEntity<string>, ISwitchable, ISortable
    {
        public string Name { set; get; }
        public string URL { set; get; }
        public string ParentId { set; get; }
        public string IconCss { get; set; }

        public int SortOrder { get; set; }
        public Status status { get; set; }
    }
}
