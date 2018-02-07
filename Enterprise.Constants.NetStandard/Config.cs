using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Constants.NetStandard
{
    public class Config
    {
        public static bool IsDevelopmentMode = true;

        public static bool IsMigration = true;
        
        public const string BearerSchema = "Bearer";
        public const string CookiesSchema = "Cookies";
        public const string oidcSchema = "oidc";
        public const string HybridResponseType = "code id_token";
        public const string OfflineAccessScope = "offline_access";

        // Will be initialized once by each app instance.
        // After initialized set this flag to true.
        public static bool IsURLInitialized = false;
    }
}
