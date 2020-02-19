using System.Collections.Generic;
using SmartClass.Roles.Dto;
using SmartClass.Users.Dto;

namespace SmartClass.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
