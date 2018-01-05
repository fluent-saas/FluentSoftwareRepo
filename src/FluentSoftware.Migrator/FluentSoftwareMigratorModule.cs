using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FluentSoftware.Configuration;
using FluentSoftware.EntityFrameworkCore;
using FluentSoftware.Migrator.DependencyInjection;

namespace FluentSoftware.Migrator
{
    [DependsOn(typeof(FluentSoftwareEntityFrameworkModule))]
    public class FluentSoftwareMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public FluentSoftwareMigratorModule(FluentSoftwareEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(FluentSoftwareMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                FluentSoftwareConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FluentSoftwareMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
