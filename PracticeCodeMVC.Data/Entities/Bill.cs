using PracticeCodeMVC.Data.Enums;
using PracticeCodeMVC.Data.Interfaces;
using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeCodeMVC.Data.Entities
{
    public class Bill : DomainEntity<int>, IDateTracking, ISwitchable
    {
        public string CustomerId { set; get; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerMessage { set; get; }

         
        public Status status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifined { get; set; }

        public virtual AppUser User { set; get; }

        public virtual ICollection<BillDetail> BillDetails { get; set;} 
    }
}