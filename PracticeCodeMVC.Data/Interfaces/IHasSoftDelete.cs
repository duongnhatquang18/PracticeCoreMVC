using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Interfaces
{
    interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
