using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Constants.NetStandard
{
    public class LoggingServerScopes
    {
        public const string full_access = "loggingserver.full_access";
        public const string read_only_access = "loggingserver.read_only_access";
        public const string write_access = "loggingserver.write_access";
        public const string delete_access = "loggingserver.delete_access";
    }
    public class ConfigurationServerScopes
    {
        public const string full_access = "configurationserver.full_access";
        public const string read_only_access = "configurationserver.read_only_access";
        public const string write_access = "configurationserver.write_access";
    }
    public class E_Commerce_ResourceServerScopes
    {
        public const string full_access = "e-commerce.resourceserver.full_access";
        public const string read_only_access = "e-commerce.resourceserver.read_only_access";
        public const string write_access = "e-commerce.resourceserver.write_access";
        public const string delete_access = "e-commerce.resourceserver.delete_access";
    }
}
