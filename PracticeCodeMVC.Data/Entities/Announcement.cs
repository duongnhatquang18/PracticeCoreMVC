using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Announcement : DomainEntity<string>, IDateTracking, ISwitchable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifined { get; set; }

        public Guid UserId { set; get; }
        public virtual ICollection<AnnouncementUser> AnnouncementUsers { get; set; }
    }
}
