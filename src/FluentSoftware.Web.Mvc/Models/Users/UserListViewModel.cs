using System.Collections.Generic;
using FluentSoftware.Roles.Dto;
using FluentSoftware.Users.Dto;

namespace FluentSoftware.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}