using Enterprise.Comparer.NetStandard;
using Enterprise.Enums.NetStandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Models.NetStandard
{
    public class LogModel
    {
        public string UserID { get; set; }
        public string UserLogin { get; set; }
        public string LoggerName { get; set; }
        public string CurrentApplication { get; set; }
        public string LogMessage { get; set; }
        public Exception LogException { get; set; }
        public LogTypeEnum LogType { get; set; }
        public LogModel()
        {

        }
        public LogModel(string userId,string userLogin)
        {
            UserID = userId;
            UserLogin = userLogin;
        }
        public override bool Equals(object obj)
        {
            var ObjToCompare = obj as LogModel;

            if (ObjToCompare == null) return false;

            bool equality = ObjToCompare.UserID == UserID
                && ObjToCompare.UserLogin == UserLogin
                && ObjToCompare.LoggerName == LoggerName
                && ObjToCompare.CurrentApplication == CurrentApplication
                && ObjToCompare.LogMessage == LogMessage
                && ExceptionComparer.Compare(ObjToCompare.LogException, LogException)
                && (int)ObjToCompare.LogType == (int)LogType;

            return equality && ObjToCompare is LogModel && ObjToCompare != null;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
