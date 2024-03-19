using Abp.Application.Services;
using ASPANGULAR.MultiTenancy.Dto;

namespace ASPANGULAR.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

