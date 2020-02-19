using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace SmartClass.Web.Views
{
    public abstract class SmartClassRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SmartClassRazorPage()
        {
            LocalizationSourceName = SmartClassConsts.LocalizationSourceName;
        }
    }
}
