using Abp.Authorization;
using FluentSoftware.Authorization.Roles;
using FluentSoftware.Authorization.Users;

namespace FluentSoftware.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
