using Enterprise.ConfigurationServer.DataLayers.ConfigurationDB;
using Enterprise.Constants.NetStandard;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Helpers.NetStandard
{
    public class InitializeStartupHelper
    {
        public static void InitializeStaticFields(IConfiguration configuration)
        {
            IEnumerable<IntegratedApp> apps = null;
            try
            {
                var opt = new DbContextOptionsBuilder().UseSqlServer(configuration.GetConnectionString(ConfigurationNames.ConfigurationConnection)).Options;
                var configurationDBContext = new ConfigurationDBContext(opt);

                // get All Apps Informations
                apps = configurationDBContext.IntegratedApps.ToListAsync().Result;

                // Re setting URl Values
                new Urls(apps);
            }
            catch
            {
                throw;
            }
        }
    }
}
