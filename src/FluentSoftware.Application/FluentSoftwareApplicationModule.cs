using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FluentSoftware.Authorization;

namespace FluentSoftware
{
    [DependsOn(
        typeof(FluentSoftwareCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FluentSoftwareApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FluentSoftwareAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FluentSoftwareApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
