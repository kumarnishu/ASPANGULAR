using System.Threading.Tasks;
using ASPANGULAR.Configuration.Dto;

namespace ASPANGULAR.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
