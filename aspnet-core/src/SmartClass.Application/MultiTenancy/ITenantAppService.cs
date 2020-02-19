using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SmartClass.MultiTenancy.Dto;

namespace SmartClass.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

