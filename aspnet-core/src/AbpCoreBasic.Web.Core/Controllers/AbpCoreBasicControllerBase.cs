using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpCoreBasic.Controllers
{
    public abstract class AbpCoreBasicControllerBase: AbpController
    {
        protected AbpCoreBasicControllerBase()
        {
            LocalizationSourceName = AbpCoreBasicConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
