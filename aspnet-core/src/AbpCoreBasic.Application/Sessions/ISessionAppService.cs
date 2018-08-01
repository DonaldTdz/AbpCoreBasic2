using System.Threading.Tasks;
using Abp.Application.Services;
using AbpCoreBasic.Sessions.Dto;

namespace AbpCoreBasic.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
