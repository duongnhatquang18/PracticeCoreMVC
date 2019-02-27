using PracticeCodeMVC.Infrastructure.SharedKenel;
using System.Collections.Generic;

namespace PracticeCodeMVC.Data.Entities
{
    public class Tag : DomainEntity<int>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<BlogTag> BlogTags { get; set; }
    }
}