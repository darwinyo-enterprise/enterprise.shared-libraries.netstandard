using Enterprise.ConfigurationServer.DataLayers.ConfigurationDB;
using Enterprise.Constants.NetStandard;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Fixtures.NetStandard
{
    public class ConfigurationDBContextFixture
    {
        private readonly ConfigurationDBContext _configurationDBContext;
        public ConfigurationDBContextFixture()
        {
            _configurationDBContext = new ConfigurationDBContext(new DbContextOptionsBuilder().UseSqlServer(TestConstants.ConfigurationDBContextCS).Options);
        }
        public ConfigurationDBContext ConfigurationDBContext { get => _configurationDBContext; }
    }
}
