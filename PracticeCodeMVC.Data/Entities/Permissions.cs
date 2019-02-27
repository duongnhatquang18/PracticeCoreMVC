using PracticeCodeMVC.Infrastructure.SharedKenel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Entities
{
    public class Permissions:DomainEntity<int>
    {
        public string RoleId { get; set; }
        public string FunctionId { get; set; }
        public bool CanCreate { set; get; }
        public bool CanRead { set; get; }
        public bool CanUpdate { set; get; }
        public bool CanDelete { set; get; }

        public virtual AppRole AppRole { get; set; }
        public virtual Function Function { get; set; }
    }
}
