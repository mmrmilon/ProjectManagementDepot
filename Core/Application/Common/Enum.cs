using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.Application.Common
{
    public enum Priorities : short
    {
        [Description("Low")]
        Low = 1,
        [Description("Moderate")]
        Moderate = 2,
        [Description("High")]
        High = 3
    }
}
