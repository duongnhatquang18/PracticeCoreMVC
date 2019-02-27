using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;

namespace PracticeCodeMVC.Data.Entities
{
    public class Menu : DomainEntity<int>, ISortable, ISwitchable
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string Css { get; set; }

        public int ParentID { get; set; }
        public int SortOrder { get; set; }
        public Status status { get; set; }
    }
}