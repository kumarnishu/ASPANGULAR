using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPANGULAR.Configuration;

namespace ASPANGULAR.Web.Host.Startup
{
    [DependsOn(
       typeof(ASPANGULARWebCoreModule))]
    public class ASPANGULARWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ASPANGULARWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPANGULARWebHostModule).GetAssembly());
        }
    }
}
