using Enterprise.Services;
using Enterprise.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Fixtures.NetStandard
{
    /// <summary>
    /// Authorization Fixture.
    /// Used For Unit Testing.
    /// </summary>
    public class AuthorizationServiceFixture
    {
        private readonly IAuthorizationService _authorizationService;
        public AuthorizationServiceFixture()
        {
            _authorizationService = new AuthorizationService();
        }
        public IAuthorizationService AuthorizationService { get => _authorizationService; }
    }
}
