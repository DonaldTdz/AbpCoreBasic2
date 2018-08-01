using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreBasic.Configuration;
using AbpCoreBasic.EntityFrameworkCore;
using AbpCoreBasic.Migrator.DependencyInjection;

namespace AbpCoreBasic.Migrator
{
    [DependsOn(typeof(AbpCoreBasicEntityFrameworkModule))]
    public class AbpCoreBasicMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AbpCoreBasicMigratorModule(AbpCoreBasicEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AbpCoreBasicMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AbpCoreBasicConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpCoreBasicMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
