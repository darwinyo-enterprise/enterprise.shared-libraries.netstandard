using Enterprise.Constants.NetStandard;
using IdentityModel.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Helpers.NetStandard
{
    /// <summary>
    /// Http Client Helper
    /// </summary>
    public class HttpClientHelper
    {
        private string AuthorityURI { get; set; }
        public string Client { get; set; }
        public string Secret { get; set; }
        public string APIScope { get; set; }
        public HttpClientHelper()
        {

        }
        public HttpClientHelper(string client, string secret, string apiScope, string authorityUri=null)
        {
            AuthorityURI = authorityUri?? Urls.AuthorizationServer_URL;
            Client = client;
            Secret = secret;
            APIScope = apiScope;
        }
        // TODO: HTTPS Configuration for production need to configure
        /// <summary>
        /// This Used For Creating HTTP Client, that has SSL Certificate.
        /// Configure Here When HTTP Config needed.
        /// </summary>
        /// <returns>
        /// Configured Http Client.
        /// </returns>
        public static HttpClient CreateHttpClient()
        {
            var httpClientHandler = new HttpClientHandler();
            if (Config.IsDevelopmentMode)
            {
                // self signed certificate ignored
                httpClientHandler.ServerCertificateCustomValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            }
            return new HttpClient(httpClientHandler);
        }

        /// <summary>
        /// Used For getting Token Response, has Access Token,Refresh Token, Identity Token, Expiry on it.
        /// Client credential Auth.
        /// </summary>
        /// <returns>
        /// Token Response.
        /// </returns>
        private async Task<TokenResponse> GetTokenResponseClientCredentialAsync()
        {
            TokenResponse tokenResponse = null;
            try
            {
                var disco = await GetDiscoveryResponse();
                // request token
                var tokenClient = new TokenClient(disco.TokenEndpoint, Client, Secret);
                tokenResponse = await tokenClient.RequestClientCredentialsAsync(APIScope);

                if (tokenResponse.IsError)
                {
                    throw new Exception(tokenResponse.Error);
                }
            }
            catch
            {
                throw;
            }

            return tokenResponse;
        }

        /// <summary>
        /// Used for Reading All Well known Discovery URL.
        /// </summary>
        /// <returns>
        /// Disco URL Response.
        /// </returns>
        private async Task<DiscoveryResponse> GetDiscoveryResponse()
        {
            // discover endpoints from metadata
            var disco = await DiscoveryClient.GetAsync(AuthorityURI);
            if (disco.IsError)
            {
                throw new Exception(disco.Error);
            }
            return disco;
        }
        
        /// <summary>
        /// Used For Get Access Token (Used for Accessing Resources API).
        /// Client Credential Auth.
        /// </summary>
        /// <returns>
        /// Access Token.
        /// </returns>
        public async Task<string> GetAccessTokenClientCredentialAsync()
        {
            var tokenResponse = await GetTokenResponseClientCredentialAsync();
            return tokenResponse.AccessToken;
        }

        /// <summary>
        ///  Used For Setting Basic Http Client Configuration.
        ///  Set Base Address
        ///  Set Media type
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="uri">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        private static void SetBasicConfig(ref HttpClient httpClient, string uri, string mediaType)
        {
            httpClient.BaseAddress = new Uri(uri);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(mediaType));
        }

        /// <summary>
        /// Used for Converting Objects to JSON, for post, put Body.
        /// </summary>
        /// <param name="obj">
        /// Object To Convert
        /// </param>
        /// <returns>
        /// Http Content has Object Serialized To JSON within it.
        /// Used for POST Action Body.
        /// </returns>
        public static HttpContent CreateHttpContentJson(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            return httpContent;
        }

        /// <summary>
        /// Used For Setting Http Client Without Bearer Token.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="uri">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <returns>
        /// Configured Http Client
        /// </returns>
        public static HttpClient SettingHttpClient(ref HttpClient httpClient, string uri, string mediaType)
        {
            SetBasicConfig(ref httpClient, uri, mediaType);
            
            return httpClient;
        }

        /// <summary>
        /// Used For Setting Http Client.
        /// Set up Access Token Bearer to Http Client.
        /// </summary>
        /// <param name="httpClient">
        /// reference http client object.
        /// </param>
        /// <param name="uri">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <returns>
        /// Configured Http Client
        /// </returns>
        public static HttpClient SettingHttpClient(ref HttpClient httpClient, string uri, string mediaType, string accessToken)
        {
            SetBasicConfig(ref httpClient, uri, mediaType);

            httpClient.SetBearerToken(accessToken);

            return httpClient;
        }
    }
}
