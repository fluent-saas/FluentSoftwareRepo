using Abp.Modules;
using Abp.Reflection.Extensions;
using FluentSoftware.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace FluentSoftware.Web.Startup
{
    [DependsOn(typeof(FluentSoftwareWebCoreModule))]
    public class FluentSoftwareWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FluentSoftwareWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<FluentSoftwareNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FluentSoftwareWebMvcModule).GetAssembly());
        }
    }
}