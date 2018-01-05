using System.Threading.Tasks;
using Abp.Application.Services;
using FluentSoftware.Sessions.Dto;

namespace FluentSoftware.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
