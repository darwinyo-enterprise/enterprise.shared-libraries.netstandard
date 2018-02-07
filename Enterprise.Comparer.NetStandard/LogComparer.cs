using Enterprise.Interfaces.NetStandard;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Comparer.NetStandard
{
    /// <summary>
    /// Used For Log Comparing.
    /// </summary>
    /// <typeparam name="T">
    /// ILogModel
    /// </typeparam>
    public class LogComparer<T> where T : ILogModel, new()
    {
        /// <summary>
        /// Compare Log
        /// </summary>
        /// <param name="x">
        /// Log 1
        /// </param>
        /// <param name="y">
        /// Log 2
        /// </param>
        /// <returns>
        /// Return True if Log Equals.
        /// </returns>
        public static bool Compare(T x, T y)
        {
            bool result = x.LogID == y.LogID
                && x.Date == y.Date
                && x.Time == y.Time
                && x.Level == y.Level
                && x.Message == y.Message
                && x.Logger == y.Logger
                && x.Exception == y.Exception
                && x.ThreadID == y.ThreadID
                && x.ThreadName == y.ThreadName
                && x.ProcessID == y.ProcessID
                && x.ProcessName == y.ProcessName
                && x.UserName == y.UserName
                && x.UserLogin == y.UserLogin
                && x.UserID == y.UserID
                && x.CurrentApplication == y.CurrentApplication;
            return result;
        }
    }
}
