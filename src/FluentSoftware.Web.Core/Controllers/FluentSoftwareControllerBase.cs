using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FluentSoftware.Controllers
{
    public abstract class FluentSoftwareControllerBase: AbpController
    {
        protected FluentSoftwareControllerBase()
        {
            LocalizationSourceName = FluentSoftwareConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
