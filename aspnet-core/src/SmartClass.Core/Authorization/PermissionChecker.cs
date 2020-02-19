using Abp.Authorization;
using SmartClass.Authorization.Roles;
using SmartClass.Authorization.Users;

namespace SmartClass.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
