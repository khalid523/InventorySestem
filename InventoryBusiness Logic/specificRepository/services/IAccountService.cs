using InventoryDataAccess.data;
using InventoryDataAccess.Model;
using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryDataAccess.services
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUser(SignUpModel signUpModel);
        Task<SignInResult> CheckPassword(SignInModel signInModel);

        Task<IdentityResult> NewRole(RoleModel roleModel);

        List<IdentityRole> GetRoles();

        Task Logout();

        Task<ApplicationUser> GetUser(string username);

        List<string> GetUserRoles(ApplicationUser user);
    }
}
