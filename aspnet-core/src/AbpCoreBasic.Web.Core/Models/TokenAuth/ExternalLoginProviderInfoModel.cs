using Abp.AutoMapper;
using AbpCoreBasic.Authentication.External;

namespace AbpCoreBasic.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
