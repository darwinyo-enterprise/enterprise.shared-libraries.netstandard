using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Enterprise.Enums.NetStandard
{
    public enum LogTypeEnum
    {
        [Description("Trace")]
        Trace,
        [Description("Debug")]
        Debug,
        [Description("Info")]
        Info,
        [Description("Warn")]
        Warn,
        [Description("Error")]
        Error,
        [Description("Fatal")]
        Fatal
    }
}
