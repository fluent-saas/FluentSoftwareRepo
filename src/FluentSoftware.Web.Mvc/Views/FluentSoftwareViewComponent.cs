using Abp.AspNetCore.Mvc.ViewComponents;

namespace FluentSoftware.Web.Views
{
    public abstract class FluentSoftwareViewComponent : AbpViewComponent
    {
        protected FluentSoftwareViewComponent()
        {
            LocalizationSourceName = FluentSoftwareConsts.LocalizationSourceName;
        }
    }
}