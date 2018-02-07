using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Enterprise.Extension.NetStandard
{
    /// <summary>
    /// Http Response Message Extension.
    /// </summary>
    public static class HttpResponseMessageExtension
    {
        /// <summary>
        /// Used For create to Http Response Message
        /// </summary>
        /// <param name="httpResponseMessage">
        /// http response message Instance
        /// </param>
        /// <param name="messageContent">
        /// message
        /// </param>
        /// <param name="statusCode">
        /// status code
        /// </param>
        /// <returns>
        /// http response message
        /// </returns>
        public static HttpResponseMessage CreateHttpResponseMessage(this HttpResponseMessage httpResponseMessage,string messageContent, HttpStatusCode statusCode)
        {
            httpResponseMessage.Content = new StringContent(messageContent);
            httpResponseMessage.StatusCode = statusCode;
            return httpResponseMessage;
        }
    }
}
