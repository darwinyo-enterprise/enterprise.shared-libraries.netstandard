using Enterprise.Interfaces.NetStandard.Services;
using Enterprise.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Fixtures.NetStandard
{
    /// <summary>
    /// Logging Fixture.
    /// Used In unit Testing only.
    /// </summary>
    public class LoggingServiceFixture
    {
        private readonly ILoggingServices _loggingServices;
        public LoggingServiceFixture()
        {
            _loggingServices = new LoggingServices();
        }
        public ILoggingServices LoggingServices { get => _loggingServices; }
    }
}
