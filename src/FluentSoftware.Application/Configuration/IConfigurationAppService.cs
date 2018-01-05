using System.Threading.Tasks;
using FluentSoftware.Configuration.Dto;

namespace FluentSoftware.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
