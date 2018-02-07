using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Enterprise.Enums.NetStandard
{
    public enum MongoLoggingCollectionEnum
    {
        [Description("ErrorLog")]
        ErrorLog,
        [Description("DebugLog")]
        DebugLog,
        [Description("AuditLog")]
        AuditLog,
    }
}
