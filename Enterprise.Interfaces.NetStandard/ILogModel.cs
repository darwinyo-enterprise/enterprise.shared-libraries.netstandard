using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Interfaces.NetStandard
{
    /// <summary>
    /// Log Model Contract.
    /// </summary>
    public interface ILogModel
    {
        string LogID { get; set; }
        string Date { get; set; }
        string Time { get; set; }
        string Level { get; set; }
        string Message { get; set; }
        string Logger { get; set; }
        string Exception { get; set; }
        int ThreadID { get; set; }
        string ThreadName { get; set; }
        int ProcessID { get; set; }
        string ProcessName { get; set; }
        string UserName { get; set; }
        string UserLogin { get; set; }
        string UserID { get; set; }
        string CurrentApplication { get; set; }
    }
}
