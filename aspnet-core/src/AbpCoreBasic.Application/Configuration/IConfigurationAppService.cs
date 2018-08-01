using System.Threading.Tasks;
using AbpCoreBasic.Configuration.Dto;

namespace AbpCoreBasic.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
