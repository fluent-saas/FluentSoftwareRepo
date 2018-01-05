using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FluentSoftware.Roles.Dto;
using FluentSoftware.Users.Dto;

namespace FluentSoftware.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
