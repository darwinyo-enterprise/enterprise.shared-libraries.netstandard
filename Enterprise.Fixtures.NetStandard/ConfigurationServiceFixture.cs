using Enterprise.Services;
using Enterprise.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Fixtures.NetStandard
{
    /// <summary>
    /// Configuration Fixture.
    /// Used for Unit Testing.
    /// </summary>
    public class ConfigurationServiceFixture
    {
        private readonly IConfigurationService _configurationService;
        public ConfigurationServiceFixture()
        {
            _configurationService = new ConfigurationService();
        }
        public IConfigurationService ConfigurationService { get => _configurationService; }
    }
}
