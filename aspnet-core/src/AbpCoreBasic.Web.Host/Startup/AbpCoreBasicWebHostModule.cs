using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpCoreBasic.Configuration;

namespace AbpCoreBasic.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpCoreBasicWebCoreModule))]
    public class AbpCoreBasicWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpCoreBasicWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpCoreBasicWebHostModule).GetAssembly());
        }
    }
}
