using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Contact : DomainEntity<int>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string Longtitude { get; set; }

        public string Latitude { get; set; }
    }
}
