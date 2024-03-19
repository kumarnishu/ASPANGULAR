using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ASPANGULAR.Controllers
{
    public abstract class ASPANGULARControllerBase: AbpController
    {
        protected ASPANGULARControllerBase()
        {
            LocalizationSourceName = ASPANGULARConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
