using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SmartClass.Controllers
{
    public abstract class SmartClassControllerBase: AbpController
    {
        protected SmartClassControllerBase()
        {
            LocalizationSourceName = SmartClassConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
