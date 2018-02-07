using Enterprise.ConfigurationServer.DataLayers.ConfigurationDB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Enterprise.Constants.NetStandard
{
    /// <summary>
    /// This Class Is URLs Consts.
    /// But This Values can be Influenced by DB.
    /// If Current Environment Is Dev => defined Values will take the place.
    /// Otherwise DB Will Take the place.
    /// All Changes Will Executed by restart Action.
    /// </summary>
    public class Urls
    {
        /// <summary>
        /// Dont forget to change Api Authorization URL In APIs.
        /// </summary>
        public static string AuthorizationServer_URL = "https://localhost:44375/";
        public static string LoggingServer_URL = "https://localhost:44387/";
        public static string ConfigurationServer_URL = "https://localhost:44309/";
        public static string ECommerce_ResourceServer_URL = "https://localhost:44310/";

        /// <summary>
        /// Must be Initialized In Apps that has dependencies to Other Apps API
        /// </summary>
        /// <param name="integratedApps">
        /// </param>
        public Urls(IEnumerable<IntegratedApp> integratedApps)
        {
            // Repopulate URL In DB
            ECommerce_ResourceServer_URL = GetURL(ref integratedApps, ApplicationNames.ECommerce_ResourceServer);
            AuthorizationServer_URL = GetURL(ref integratedApps, ApplicationNames.AuthorizationServer);
            LoggingServer_URL = GetURL(ref integratedApps, ApplicationNames.LoggingServer);
            ConfigurationServer_URL = GetURL(ref integratedApps, ApplicationNames.ConfigurationServer);
        }

        /// <summary>
        /// used privately for get Application URL
        /// </summary>
        /// <param name="integratedApps"></param>
        /// <param name="applicationName"></param>
        /// <returns></returns>
        private string GetURL(ref IEnumerable<IntegratedApp> integratedApps,string applicationName)
        {
            return integratedApps.Where(x => x.ApplicationName == applicationName).FirstOrDefault().ApplicationURL;
        }
    }
}
