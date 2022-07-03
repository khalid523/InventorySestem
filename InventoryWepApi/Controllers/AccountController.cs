using InventoryDataAccess.Model;
using InventoryDataAccess.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SessionWebApi2102.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountService accountService;
        IConfiguration configuration;

        public AccountController(IAccountService _accountService, IConfiguration _configuration)
        {
            accountService = _accountService;
            configuration = _configuration;
        }
        
        [HttpPost]
        [Route("CreateAccount")]
        public async Task<IActionResult> CreateAccount(SignUpModel signUpModel)
        {
           var result= await accountService.CreateUser(signUpModel);
            if (result.Succeeded)
            {
                return Ok("Success");
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole(RoleModel roleModel)
        {
            var result= await accountService.NewRole(roleModel);
            if (result.Succeeded)
            {
                return Ok("Success");
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(SignInModel signInModel)
        {
            var result=await accountService.CheckPassword(signInModel);
            if (result.Succeeded)
            {
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,signInModel.Username),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                };

               var user= await accountService.GetUser(signInModel.Username);

                var userRoles = accountService.GetUserRoles(user);

                foreach (string item in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, item));
                }


                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWTSecret"]));

                var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(15),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

                /* return Ok(new JwtSecurityTokenHandler().WriteToken(token));*/
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            else
            {
                return Unauthorized();
            }


        }

    }
}
