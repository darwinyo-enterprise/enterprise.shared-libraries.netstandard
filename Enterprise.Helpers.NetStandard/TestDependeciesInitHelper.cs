using Enterprise.ConfigurationServer.DataLayers.ConfigurationDB;
using Enterprise.Constants.NetStandard;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Helpers.NetStandard
{
    /// <summary>
    /// Used for Initialize Dependecies In Unit Testing
    /// </summary>
    public class TestDependeciesInitHelper
    {
        //public static void ConfigurationDependecies(
        //    ref ConfigurationDBContext _configurationDBContext,
        //    ref IConfigurationDBUnitOfWork _configurationDBUnitOfWork,
        //    ref IApplicationConfigurationRepository _applicationConfigurationRepository,
        //    ref IIntegratedAppRepository _integratedAppRepository,
        //    ref IUrlConfigurationTerminal _urlConfigurationTerminal,
        //    ref Urls urls)
        //{
        //    var options = new DbContextOptionsBuilder<ConfigurationDBContext>().UseSqlServer(TestConstants.ConfigurationDBContextCS);
        //    _configurationDBContext = new ConfigurationDBContext(options.Options);
        //    _applicationConfigurationRepository = new ApplicationConfigurationRepository(_configurationDBContext);
        //    _integratedAppRepository = new IntegratedAppRepository(_configurationDBContext);
        //    _configurationDBUnitOfWork = new ConfigurationDBUnitOfWork(_configurationDBContext, _applicationConfigurationRepository, _integratedAppRepository);
        //    _urlConfigurationTerminal = new UrlConfigurationTerminal(_configurationDBUnitOfWork);

        //    urls = new Urls(_urlConfigurationTerminal);
        //}
    }
}
