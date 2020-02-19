using Abp.AspNetCore.Mvc.ViewComponents;

namespace SmartClass.Web.Views
{
    public abstract class SmartClassViewComponent : AbpViewComponent
    {
        protected SmartClassViewComponent()
        {
            LocalizationSourceName = SmartClassConsts.LocalizationSourceName;
        }
    }
}
