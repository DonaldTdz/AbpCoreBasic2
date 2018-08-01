using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpCoreBasic.EntityFrameworkCore
{
    public static class AbpCoreBasicDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpCoreBasicDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpCoreBasicDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
