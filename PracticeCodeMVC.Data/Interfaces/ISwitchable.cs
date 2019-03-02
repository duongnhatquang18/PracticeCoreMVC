using PracticeCodeMVC.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
