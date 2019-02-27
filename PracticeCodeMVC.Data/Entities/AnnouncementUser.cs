using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class AnnouncementUser :DomainEntity<int>
    {
        public string AnnouncementId { get; set; }
        public string UserId { get; set; }
        public bool? HasRead { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
