using System.Threading.Tasks;
using Abp.Application.Services;
using AbpCoreBasic.Authorization.Accounts.Dto;

namespace AbpCoreBasic.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
