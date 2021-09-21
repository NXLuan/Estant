using Estant.Material.Model.DTOModel;
using Estant.Material.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Estant.Material;


namespace Estant.Core.Mappings
{
    public static class UserMapping
    {
        public static UserViewModel ToViewModel(this UserDTO dto)
        {
            UserViewModel vm = null;

            if (dto != null)
            {
                vm = new UserViewModel()
                {
                    DisplayName = dto.DISPLAYNAME,
                    Email = dto.EMAIL,
                    PhotoUrl = dto.PHOTOURL,
                    Token = dto.GenerateToken(),
                };
            }

            return vm;
        }

        public static string GenerateToken(this UserDTO dto)
        {
            string tokenString = string.Empty;

            if (dto != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigConstants.JwtKey));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Jti, dto.UID),
            };

                var token = new JwtSecurityToken(
                    ConfigConstants.JwtIssuer,
                    ConfigConstants.JwtIssuer,
                    claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials);

                tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            }

            return tokenString;
        }
    }
}
