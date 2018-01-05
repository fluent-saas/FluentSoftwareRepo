using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FluentSoftware.Configuration;

namespace FluentSoftware.Web.Host.Startup
{
    [DependsOn(
       typeof(FluentSoftwareWebCoreModule))]
    public class FluentSoftwareWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FluentSoftwareWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FluentSoftwareWebHostModule).GetAssembly());
        }
    }
}
