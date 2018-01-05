using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FluentSoftware.Web.Views
{
    public abstract class FluentSoftwareRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FluentSoftwareRazorPage()
        {
            LocalizationSourceName = FluentSoftwareConsts.LocalizationSourceName;
        }
    }
}
