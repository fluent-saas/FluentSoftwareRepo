using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FluentSoftware.Configuration.Dto;

namespace FluentSoftware.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FluentSoftwareAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
