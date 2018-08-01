using Abp.Authorization;
using AbpCoreBasic.Authorization.Roles;
using AbpCoreBasic.Authorization.Users;

namespace AbpCoreBasic.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
