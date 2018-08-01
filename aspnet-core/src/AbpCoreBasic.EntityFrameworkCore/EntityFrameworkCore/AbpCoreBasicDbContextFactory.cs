using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpCoreBasic.Configuration;
using AbpCoreBasic.Web;

namespace AbpCoreBasic.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpCoreBasicDbContextFactory : IDesignTimeDbContextFactory<AbpCoreBasicDbContext>
    {
        public AbpCoreBasicDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpCoreBasicDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpCoreBasicDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpCoreBasicConsts.ConnectionStringName));

            return new AbpCoreBasicDbContext(builder.Options);
        }
    }
}
