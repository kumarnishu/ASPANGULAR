using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ASPANGULAR.Configuration.Dto;

namespace ASPANGULAR.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ASPANGULARAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
