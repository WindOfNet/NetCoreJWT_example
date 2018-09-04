using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly JwtSettings _jwtSettings;

        public AuthController(IOptions<JwtSettings> jwtSettings)
        {
            this._jwtSettings = jwtSettings.Value;
        }

        // GET: api/Auth
        [HttpGet]
        public ActionResult<string> Get(string user)
        {
            if (string.IsNullOrWhiteSpace(user))
            {
                return BadRequest("user is empty");
            }

            // 身分集合
            var claim = new Claim[] {
                    new Claim(ClaimTypes.Name, user),
                    // new Claim(ClaimTypes.Role, "role")
                };

            // 對稱祕鑰
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            // 簽名證書(祕鑰，加密演算法)
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            // token
            var token = new JwtSecurityToken("issuer", "audience", claim, null, DateTime.Now.AddYears(1), creds);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
        }
    }
}
