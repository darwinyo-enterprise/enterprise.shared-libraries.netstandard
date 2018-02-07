using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Constants.NetStandard
{
    // TODO : List out All privilages each roles has...
    // TODO : Add To Front end Too For Sync...

    /// <summary>
    /// This Class Contain Application Scope Roles.
    /// </summary>
    public class AppRoleNames
    {
        #region Enterprise Solution Scopes
        /// <summary>
        /// This Role has the Highest Privilages.
        /// Has All Permissions.
        /// </summary>
        public const string Enterprise_SuperAdministrator = "Enterprise.SuperAdministrator";
        /// <summary>
        /// This Role has only managing security Concern Privilages.
        /// Managing SQL Connection, Changing Apps SSL, 
        /// Certificates Settings.
        /// </summary>
        public const string Enterprise_SecurityAdministrator = "Enterprise.SecurityAdministrator";

        /// <summary>
        /// This Role Only Give User Access To Admin Area.
        /// All Above Admins will Get This Role too.
        /// If Not Given this Role They Couldn't even open Admin Module.
        /// </summary>
        public const string Enterprise_Administrator = "Enterprise.Administrator";

        #endregion

        #region E-Commerce Scope
        /// <summary>
        /// This Role has the Highest Privilages.
        /// Has All Permissions.
        /// </summary>
        public const string ECommerce_SuperAdministrator = "E-Commerce.SuperAdministrator";
        /// <summary>
        /// This Role has only managing security Concern Privilages.
        /// Managing SQL Connection, Changing Apps SSL, 
        /// Certificates Settings.
        /// </summary>
        public const string ECommerce_SecurityAdministrator = "ECommerce.SecurityAdministrator";

        /// <summary>
        /// This Role Only Give User Access To Admin Area.
        /// All Above Admins will Get This Role too.
        /// If Not Given this Role They Couldn't even open Admin Module.
        /// </summary>
        public const string ECommerce_Administrator = "ECommerce.Administrator";
        
        /// <summary>
        /// Most Least Privilages Role.
        /// </summary>
        public const string ECommerce_End_User = "E-Commerce.EndUser";
        
        #endregion

        #region Configuration Server Scope
        /// <summary>
        /// This Role has the Highest Privilages.
        /// Has All Permissions.
        /// </summary>
        public const string ConfigurationServer_SuperAdministrator = "ConfigurationServer.SuperAdministrator";
        /// <summary>
        /// This Role has only managing security Concern Privilages.
        /// Managing SQL Connection, Changing Apps SSL, 
        /// Certificates Settings.
        /// </summary>
        public const string ConfigurationServer_SecurityAdministrator = "ConfigurationServer.SecurityAdministrator";

        /// <summary>
        /// This Role Only Responsible for Changing Application Configuration, Add Application variables,etc
        /// </summary>
        public const string ConfigurationServer_ConfigAdministrator = "ConfigurationServer.ConfigAdministrator";

        /// <summary>
        /// This Role Only Give User Access To Admin Area.
        /// All Above Admins will Get This Role too.
        /// If Not Given this Role They Couldn't even open Admin Module.
        /// </summary>
        public const string ConfigurationServer_Administrator = "ConfigurationServer.Administrator";
        #endregion


        #region Authorization Server Scope
        /// <summary>
        /// This Role has the Highest Privilages.
        /// Has All Permissions.
        /// </summary>
        public const string AuthorizationServer_SuperAdministrator = "AuthorizationServer.SuperAdministrator";
        /// <summary>
        /// This Role has only managing security Concern Privilages.
        /// Managing SQL Connection, Changing Apps SSL, 
        /// Certificates Settings.
        /// </summary>
        public const string AuthorizationServer_SecurityAdministrator = "AuthorizationServer.SecurityAdministrator";

        /// <summary>
        /// This Role Responsible for Manipulate User Info Data, Unlock Account, Lock Account, Delete,Even Create.
        /// Has Privilage all about user
        /// </summary>
        public const string AuthorizationServer_UserAdministrator = "AuthorizationServer.UserAdministrator";

        /// <summary>
        /// This Role Only Give User Access To Admin Area.
        /// All Above Admins will Get This Role too.
        /// If Not Given this Role They Couldn't even open Admin Module.
        /// </summary>
        public const string AuthorizationServer_Administrator = "AuthorizationServer.Administrator";
        #endregion

        #region Logging Server Scope
        /// <summary>
        /// This Role has the Highest Privilages.
        /// Has All Permissions.
        /// </summary>
        public const string LoggingServer_SuperAdministrator = "LoggingServer.SuperAdministrator";
        /// <summary>
        /// This Role has only managing security Concern Privilages.
        /// Managing SQL Connection, Changing Apps SSL, 
        /// Certificates Settings.
        /// </summary>
        public const string LoggingServer_SecurityAdministrator = "LoggingServer.SecurityAdministrator";

        /// <summary>
        /// This Role Only Responsible for View All Event Logs.Modify And Delete.
        /// </summary>
        public const string LoggingServer_AuditAdministrator = "LoggingServer.AuditAdministrator";

        /// <summary>
        /// This Role Only Give User Access To Admin Area.
        /// All Above Admins will Get This Role too.
        /// If Not Given this Role They Couldn't even open Admin Module.
        /// </summary>
        public const string LoggingServer_Administrator = "LoggingServer.Administrator";
        #endregion

    }
}
