using Enterprise.Enums.NetStandard;
using Enterprise.Models.NetStandard;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Extension.NetStandard
{
    /// <summary>
    /// Log Model Extension
    /// </summary>
    public static class LogModelExtension
    {
        /// <summary>
        /// Used for instantiate Log Model.
        /// </summary>
        /// <param name="logModel">
        /// instance of log model
        /// </param>
        /// <param name="userID">
        /// current Logged User ID.
        /// Can be null for client credential scenario.
        /// </param>
        /// <param name="userName">
        /// Current Logged User Name
        /// Can be null for client credential scenario.
        /// </param>
        /// <param name="loggerName">
        /// Current Logger Name
        /// </param>
        /// <param name="currentApplication">
        /// Current App Who tries to logging.
        /// </param>
        /// <param name="logType">
        /// Warn,Debug,Error,Info,etc.
        /// </param>
        /// <param name="logMessage">
        /// Messages.
        /// </param>
        /// <param name="logException">
        /// Nullable in Not Error, Fatal Scenario.
        /// </param>
        /// <returns>
        /// instance of log model.
        /// </returns>
        public static LogModel SetModel(this LogModel logModel,string userID,string userName, string loggerName, string currentApplication, LogTypeEnum logType, string logMessage = null, Exception logException = null)
        {
            logModel.LoggerName = loggerName;
            logModel.CurrentApplication = currentApplication;
            logModel.LogType = logType;
            logModel.LogMessage = logMessage;
            logModel.LogException = logException;
            logModel.UserID = userID;
            logModel.UserLogin = userName;
            return logModel;
        }
    }
}
