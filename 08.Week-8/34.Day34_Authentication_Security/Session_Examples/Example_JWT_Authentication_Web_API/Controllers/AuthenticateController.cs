using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticateController : ControllerBase
    {
        public List<UserModel> usersList = null;

        public AuthenticateController()
        {
            usersList = new List<UserModel>()
            {
                new UserModel() { UserName = "Admin", Password = "Admin123", Role="Admin" },
                new UserModel() { UserName = "Scott", Password = "Scott123", Role="Default"}
            };
        }


        [HttpPost]
        public IActionResult Login(UserModel requestUser)
        {
            // 1.  Verify the user credentails
            UserModel userObj = usersList.Where(x => x.UserName ==
requestUser.UserName && x.Password == requestUser.Password).FirstOrDefault();


            if (userObj != null)
            {
                // 2.  Generate JWT Token
                string tokenStr = GenerateJSONWebToken(userObj);
                return Ok(new { token = tokenStr });
            }
            else
            {
                return BadRequest("Invalid user id or password");
            } 
        }


        private string GenerateJSONWebToken(UserModel userObj)
        {
            SymmetricSecurityKey securityKey = new
SymmetricSecurityKey(Encoding.UTF8.GetBytes("Your_Secret_Key_Here_ASKJFALKDJF57454897454"));

            SigningCredentials credentials = new SigningCredentials(securityKey,
            SecurityAlgorithms.HmacSha256);


            List<Claim> authClaims = new List<Claim>
            {
                    new  Claim(ClaimTypes.NameIdentifier,Convert.ToString(userObj.UserName)),
                    new Claim(ClaimTypes.Name, userObj.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // (JWT ID) Claim
                    new Claim(ClaimTypes.Role, userObj.Role)
            };

            JwtSecurityToken token = new JwtSecurityToken(
                        issuer: "YourIssuer",
                        audience: "YourAudience",
                        claims: authClaims,
                        expires: DateTime.Now.AddMinutes(2),
                        signingCredentials: credentials);

            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenString;
        }

    }
}
