 using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using PlasticosFortuna.Data.Repositories;
using PlasticosFortuna.Shared;

namespace PlasticosFortuna.Api.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private IUserRepository _userRepository;
        
        public LoginController(IConfiguration config, IUserRepository userRepository)
        {
            _config = config;
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult Login([FromBody] UserModel login)
        {
            
            IActionResult response = Unauthorized();

            var user = AuthenticateUser(login);

            String hashedPassword = GenerateSHA256Hash(login.Password, user.Salt);

            if (user != null && (user.Password == hashedPassword))
            {
                var tokenStr = GenerateJSONWebToken(user);
                Response.Headers.Add("X-AuthenticationToken", tokenStr);
                response = Ok(new { user.EmailAddress,  user.LoginId, user.Salt, user.UserName, user.UserRole});
            }

            return response;
        }

        private UserModel AuthenticateUser( UserModel login)
        {
            return _userRepository.GetLoginUser(login);
        }

        private String CreateSalt(int size)
        {
            var rng = RandomNumberGenerator.Create();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private String GenerateSHA256Hash(String input, String salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256 sha256HashString = SHA256.Create();
            byte[] hash = sha256HashString.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }

        private string ByteArrayToHexString(byte[] hash)
        {
            StringBuilder hex = new StringBuilder(hash.Length * 2);
            foreach (byte c in hash)
            {
                hex.AppendFormat("{0:x2}", c);
            }
            return hex.ToString();
        }

        private string GenerateJSONWebToken(UserModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,userInfo.UserName),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.EmailAddress),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, userInfo.UserRole.RoleName)
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
                );

            var encodeToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodeToken;
        }

        [Authorize]
        [HttpPost("Post")]
        public string Post()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claim = identity.Claims.ToList();
            var username = claim[0].Value;
            return "Welcome To: " + username;
        }

        [Authorize(Roles ="Administrador")]
        [HttpGet("GetValue")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Value1", "Value2", "Value3" };
        }
    }
}