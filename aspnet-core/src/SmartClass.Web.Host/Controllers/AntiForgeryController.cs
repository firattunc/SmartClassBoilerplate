using Microsoft.AspNetCore.Antiforgery;
using SmartClass.Controllers;

namespace SmartClass.Web.Host.Controllers
{
    public class AntiForgeryController : SmartClassControllerBase
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
