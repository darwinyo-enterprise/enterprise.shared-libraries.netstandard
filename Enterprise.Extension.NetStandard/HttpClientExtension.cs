using Enterprise.ConfigurationServer.DataLayers.ConfigurationDB;
using Enterprise.Constants.NetStandard;
using Enterprise.E_Commerce.NetStandard.DataLayers.ECommerceDB;
using Enterprise.Enums.NetStandard;
using Enterprise.Helpers.NetStandard;
using Enterprise.Models.NetStandard;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Extension.NetStandard
{
    /// <summary>
    /// Http Clients Extensions...
    /// </summary>
    public static class HttpClientExtension
    {

        /// <summary>
        /// For Making Decision Where we should store our Logs In Mongodb.
        /// </summary>
        /// <param name="IsDevMode">
        /// nullable, if null this will check to configuration constant.
        /// if defined, value will defined by what we defined.
        /// </param>
        /// <returns>
        /// Is Dev Environment.
        /// </returns>
        private static bool IsDevelopmentMode(bool? IsDevMode)
        {
            bool DevMode = false;
            if (IsDevMode == null)
            {
                DevMode = Config.IsDevelopmentMode;
            }
            else
            {
                DevMode = IsDevMode.Value;
            }
            return DevMode;
        }


        #region Resources

        #region LogServer
        /// <summary>
        /// Used to Add New Log Record
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="logModel">
        /// Object to log
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <param name="IsDevMode">
        /// nullable, if null this will check to configuration constant.
        /// if defined, value will defined by what we defined.
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> PostLoggingAsync(this HttpClient httpClient, LogModel logModel, string mediaType, bool? IsDevMode = null)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.LoggingServer_URL, mediaType);
            if (!IsDevelopmentMode(IsDevMode))
            {
                switch (logModel.LogType)
                {
                    case LogTypeEnum.Debug:
                    case LogTypeEnum.Trace:
                        return await httpClient.PostLoggingAsync(logModel, Constants.NetStandard.LoggingServer.ControllerUrls.DebugLog_URL);
                    case LogTypeEnum.Error:
                    case LogTypeEnum.Fatal:
                        return await httpClient.PostLoggingAsync(logModel, Constants.NetStandard.LoggingServer.ControllerUrls.ErrorLog_URL);
                    case LogTypeEnum.Info:
                    case LogTypeEnum.Warn:
                        return await httpClient.PostLoggingAsync(logModel, Constants.NetStandard.LoggingServer.ControllerUrls.AuditLog_URL);
                    default:
                        break;
                }
            }
            logModel.LoggerName = "Debug." + logModel.LoggerName;
            return await httpClient.PostLoggingAsync(logModel, Constants.NetStandard.LoggingServer.ControllerUrls.DebugLog_URL);
        }

        /// <summary>
        /// Used to Get All Logs
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="controllerUrls">
        /// AuditLog, DebugLog, ErrorLog.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> GetAllLoggingAsync(this HttpClient httpClient, string controllerUrls, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.LoggingServer_URL, mediaType, accessToken);
            return await httpClient.GetAsync(controllerUrls);
        }

        /// <summary>
        /// Delete Single Log By Id
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="Id">
        /// GUID Logging.
        /// </param>
        /// <param name="controllerUrls">
        /// AuditLog, DebugLog, ErrorLog.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> DeleteLoggingByIDAsync(this HttpClient httpClient, string Id, string controllerUrls, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.LoggingServer_URL, mediaType, accessToken);
            return await httpClient.DeleteAsync(controllerUrls + "/" + Id);
        }

        /// <summary>
        /// Delete All Log
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="controllerUrls">
        /// AuditLog, DebugLog, ErrorLog.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> DeleteLoggingAllAsync(this HttpClient httpClient, string controllerUrls, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.LoggingServer_URL, mediaType, accessToken);
            return await httpClient.DeleteAsync(controllerUrls);
        }

        /// <summary>
        /// Get All Log By Specific Date.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="dateTime">
        /// Target Date 
        /// </param>
        /// <param name="controllerUrls">
        /// AuditLog, DebugLog, ErrorLog.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> GetListLoggingByDateAsync(this HttpClient httpClient, DateTime dateTime, string controllerUrls, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.LoggingServer_URL, mediaType, accessToken);
            return await httpClient.GetAsync(controllerUrls + "/search/" + dateTime.ToString("dd-MM-yyyy"));
        }

        /// <summary>
        /// Get Single Log By Id
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="Id">
        /// GUID Logging.
        /// </param>
        /// <param name="controllerUrls">
        /// AuditLog, DebugLog, ErrorLog.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> GetLoggingByIdAsync(this HttpClient httpClient, string Id, string controllerUrls, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.LoggingServer_URL, mediaType, accessToken);
            return await httpClient.GetAsync(controllerUrls + "/" + Id);
        }

        /// <summary>
        /// Not Used Widely. Only Within This Class.
        /// Used For Add New Log Record.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="logModel">
        /// Object to log
        /// </param>
        /// <param name="controllerUrls">
        /// AuditLog, DebugLog, ErrorLog.
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        private static async Task<HttpResponseMessage> PostLoggingAsync(this HttpClient httpClient, LogModel logModel, string controllerUrl)
        {
            var content = HttpClientHelper.CreateHttpContentJson(logModel);
            return await httpClient.PostAsync(controllerUrl, content);
        }

        #endregion

        #region ConfigurationServer
        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> GetAllConfigurationAsync(this HttpClient httpClient, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ConfigurationServer_URL, mediaType, accessToken);
            return await httpClient.GetAsync(Constants.NetStandard.ConfigurationServer.ControllerUrls.AppsConfiguration_URL);
        }

        /// <summary>
        /// Update Single Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="Id">
        /// GUID Key.
        /// </param>
        /// <param name="value">
        /// Value For Update.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> UpdateConfigurationAsync(this HttpClient httpClient, string Id, string value, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ConfigurationServer_URL, mediaType, accessToken);
            var content = HttpClientHelper.CreateHttpContentJson(value);
            return await httpClient.PutAsync(Constants.NetStandard.ConfigurationServer.ControllerUrls.AppsConfiguration_URL + "/" + Id, content);
        }

        /// <summary>
        /// Used For Get All URL Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> GetAllURLConfigurationAsync(this HttpClient httpClient, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ConfigurationServer_URL, mediaType, accessToken);
            return await httpClient.GetAsync(Constants.NetStandard.ConfigurationServer.ControllerUrls.URLConfiguration_URL);
        }

        /// <summary>
        /// Used For Update Single URL Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="Id">
        /// GUID Key.
        /// </param>
        /// <param name="integratedApp">
        /// Object For Update.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> UpdateURLConfigurationAsync(this HttpClient httpClient, string Id, IntegratedApp integratedApp, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ConfigurationServer_URL, mediaType, accessToken);
            var content = HttpClientHelper.CreateHttpContentJson(integratedApp);
            return await httpClient.PutAsync(Constants.NetStandard.ConfigurationServer.ControllerUrls.URLConfiguration_URL + "/" + Id, content);
        }
        #endregion

        #region ECommerce ResourceServer
        // TODO : Clean This...
        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="category">
        /// Object To Add
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> PostCategoryAsync(this HttpClient httpClient, Category category, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            var content = HttpClientHelper.CreateHttpContentJson(category);
            return await httpClient.PostAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.Category_URL, content);
        }

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="Id">
        /// GUID Key.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> DeleteCategoryByIDAsync(this HttpClient httpClient, Guid Id, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            return await httpClient.DeleteAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.Category_URL + "/" + Id);
        }

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> DeleteAllCategoryAsync(this HttpClient httpClient, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            return await httpClient.DeleteAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.Category_URL);
        }

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> GetAllCategoryAsync(this HttpClient httpClient, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            return await httpClient.GetAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.Category_URL);
        }

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="Id">
        /// GUID Key.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> GetCategoryByIdAsync(this HttpClient httpClient, Guid Id, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            return await httpClient.GetAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.Category_URL + "/" + Id);
        }

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="category">
        /// Object To Add
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> PostSubCategoryAsync(this HttpClient httpClient, Category category, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            var content = HttpClientHelper.CreateHttpContentJson(category);
            return await httpClient.PostAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.SubCategory_URL, content);
        }

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="Id">
        /// GUID Key.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> DeleteSubCategoryByIDAsync(this HttpClient httpClient, Guid Id, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            return await httpClient.DeleteAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.SubCategory_URL + "/" + Id);
        }

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> DeleteAllSubCategoryAsync(this HttpClient httpClient, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            return await httpClient.DeleteAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.SubCategory_URL);
        }

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> GetAllSubCategoryAsync(this HttpClient httpClient, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            return await httpClient.GetAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.SubCategory_URL);
        }

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="Id">
        /// GUID Key.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public static async Task<HttpResponseMessage> GetSubCategoryByIdAsync(this HttpClient httpClient, Guid Id, string accessToken, string mediaType)
        {
            httpClient = HttpClientHelper.SettingHttpClient(ref httpClient, Urls.ECommerce_ResourceServer_URL, accessToken, mediaType);
            return await httpClient.GetAsync(Constants.NetStandard.ECommerce_ResourceServer.ControllerUrls.SubCategory_URL + "/" + Id);
        }
        #endregion

        #endregion
    }
}
