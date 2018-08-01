using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpCoreBasic.Authorization.Roles;
using AbpCoreBasic.Authorization.Users;
using AbpCoreBasic.MultiTenancy;

namespace AbpCoreBasic.EntityFrameworkCore
{
    public class AbpCoreBasicDbContext : AbpZeroDbContext<Tenant, Role, User, AbpCoreBasicDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpCoreBasicDbContext(DbContextOptions<AbpCoreBasicDbContext> options)
            : base(options)
        {
        }
    }
}
