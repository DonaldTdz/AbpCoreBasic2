using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreBasic.Authorization;

namespace AbpCoreBasic
{
    [DependsOn(
        typeof(AbpCoreBasicCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpCoreBasicApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpCoreBasicAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpCoreBasicApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
