using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPANGULAR.EntityFrameworkCore;
using ASPANGULAR.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ASPANGULAR.Web.Tests
{
    [DependsOn(
        typeof(ASPANGULARWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ASPANGULARWebTestModule : AbpModule
    {
        public ASPANGULARWebTestModule(ASPANGULAREntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPANGULARWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ASPANGULARWebMvcModule).Assembly);
        }
    }
}