using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ASPANGULAR.Authorization.Roles;
using ASPANGULAR.Authorization.Users;
using ASPANGULAR.MultiTenancy;

namespace ASPANGULAR.EntityFrameworkCore
{
    public class ASPANGULARDbContext : AbpZeroDbContext<Tenant, Role, User, ASPANGULARDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ASPANGULARDbContext(DbContextOptions<ASPANGULARDbContext> options)
            : base(options)
        {
        }
    }
}
