using Microsoft.AspNetCore.Antiforgery;
using AbpCoreBasic.Controllers;

namespace AbpCoreBasic.Web.Host.Controllers
{
    public class AntiForgeryController : AbpCoreBasicControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
