using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;

namespace PracticeCodeMVC.Data.Entities
{
    public class Slide : DomainEntity<int>, ISortable, ISwitchable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Content { set; get; }
        public string GroupAlias { get; set; }

        public Status Status { get; set; }
        public int SortOrder { get; set; }
    }
}