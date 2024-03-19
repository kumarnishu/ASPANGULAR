using System.Threading.Tasks;
using Abp.Application.Services;
using ASPANGULAR.Sessions.Dto;

namespace ASPANGULAR.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
