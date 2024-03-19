using System.Threading.Tasks;
using Abp.Application.Services;
using ASPANGULAR.Authorization.Accounts.Dto;

namespace ASPANGULAR.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
