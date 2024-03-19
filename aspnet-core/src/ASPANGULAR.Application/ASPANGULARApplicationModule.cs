using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPANGULAR.Authorization;

namespace ASPANGULAR
{
    [DependsOn(
        typeof(ASPANGULARCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ASPANGULARApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ASPANGULARAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ASPANGULARApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
