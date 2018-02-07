using Enterprise.Services;
using Enterprise.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Fixtures.NetStandard
{
    /// <summary>
    /// E-Commerce Fixture.
    /// Used In Unit Testing Only.
    /// </summary>
    public class ECommerceServiceFixture
    {
        private readonly IECommerceService _eCommerceService;
        public ECommerceServiceFixture()
        {
            _eCommerceService = new ECommerceService();
        }
        public IECommerceService ECommerceService { get => _eCommerceService; }
    }
}
