using Enterprise.Enums.NetStandard;
using Enterprise.Models.NetStandard;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.ActionResults.NetStandard
{
    /// <summary>
    /// Only Used In Logging Service For Exception.
    /// No Other Service or class can use this Method.
    /// </summary>
    public class LogServiceExceptionResult : ActionResult
    {
        private readonly Exception _exception;
        private readonly ILogger _logger;
        public LogServiceExceptionResult(Exception exception, ILogger logger)
        {
            _exception = exception;
            _logger = logger;
        }
        public override void ExecuteResult(ActionContext context)
        {
            #region Log Terminal
            var userScopesModel = new UserScopesModel(context.HttpContext);
            var logModel = new LogModel()
            {
                CurrentApplication = _exception.Source,
                LogException = _exception,
                LoggerName = _exception.Source,
                LogMessage = _exception.Message,
                LogType = LogTypeEnum.Error,
                UserID = userScopesModel.Subject.ToString(),
                UserLogin = userScopesModel.Name
            };

            _logger.Error(logModel);
            #endregion
            var response = context.HttpContext.Response;
            var result = JsonConvert.SerializeObject(new { error = _exception.Message });
            response.ContentType = "application/json";
            response.StatusCode = (int)HttpStatusCode.BadRequest;
            response.WriteAsync(result).Wait();
        }
    }
}
