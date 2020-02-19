using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SmartClass.Controllers;

namespace SmartClass.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : SmartClassControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
