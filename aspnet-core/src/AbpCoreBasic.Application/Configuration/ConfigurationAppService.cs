using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpCoreBasic.Configuration.Dto;

namespace AbpCoreBasic.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpCoreBasicAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
