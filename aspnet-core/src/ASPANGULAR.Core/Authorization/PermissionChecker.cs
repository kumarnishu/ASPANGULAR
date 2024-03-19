using Abp.Authorization;
using ASPANGULAR.Authorization.Roles;
using ASPANGULAR.Authorization.Users;

namespace ASPANGULAR.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
