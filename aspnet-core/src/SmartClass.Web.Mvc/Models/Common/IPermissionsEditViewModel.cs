using System.Collections.Generic;
using SmartClass.Roles.Dto;

namespace SmartClass.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}