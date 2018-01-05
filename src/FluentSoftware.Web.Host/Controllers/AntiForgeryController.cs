using Microsoft.AspNetCore.Antiforgery;
using FluentSoftware.Controllers;

namespace FluentSoftware.Web.Host.Controllers
{
    public class AntiForgeryController : FluentSoftwareControllerBase
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
