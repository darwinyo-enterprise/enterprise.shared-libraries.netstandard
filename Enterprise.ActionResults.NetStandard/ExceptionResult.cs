using Enterprise.Enums.NetStandard;
using Enterprise.Interfaces.NetStandard.Services;
using Enterprise.Models.NetStandard;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Enterprise.ActionResults.NetStandard
{
    /// <summary>
    /// Used when Exception Occured.
    /// This Will Return Response JSON {error : "error messages"}
    /// This will be used in all api except logging service.
    /// Used LogServiceExceptionResult Instead for Logging Service.
    /// </summary>
    public class ExceptionResult : ActionResult
    {
        private readonly Exception _exception;

        private readonly ILoggingServices _loggingServices;

        public ExceptionResult(Exception exception,ILoggingServices loggingServices)
        {
            _exception = exception;
            _loggingServices = loggingServices;
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

            _loggingServices.LogAsync(logModel);
            #endregion

            var response = context.HttpContext.Response;
            var result = JsonConvert.SerializeObject(new { error = _exception.Message });
            response.ContentType = "application/json";
            response.StatusCode = (int)HttpStatusCode.BadRequest;
            response.WriteAsync(result);
        }
    }
}
