using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FluentSoftware.MultiTenancy.Dto;

namespace FluentSoftware.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
