using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SmartClass.Controllers;

namespace SmartClass.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SmartClassControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
