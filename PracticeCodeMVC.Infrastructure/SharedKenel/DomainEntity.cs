using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Infrastructure.SharedKenel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }
    }
}
