using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class FeedBack: DomainEntity<int>, IDateTracking, ISwitchable
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Content { get; set; }
        public Status status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifined { get; set; }
    }
}
