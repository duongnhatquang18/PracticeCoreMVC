using Microsoft.AspNetCore.Identity;
using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }
        public DateTime? BirthDay { set; get; }
        public decimal Balance { get; set; }
        public string Avatar { get; set; }

        public Status status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifined { get; set; }

        public virtual AnnouncementUser AnnouncementUser { get; set; }
    }
}
