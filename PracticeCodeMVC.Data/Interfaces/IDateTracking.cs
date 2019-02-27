using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }
        DateTime DateModifined { get; set; }

    }
}
