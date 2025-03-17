﻿using CoreBusiness;
using CoreBusiness.Config;
using CoreBusiness.ForLogin;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.AuthenUseCase
{
    public class AuthenService : IAuthenService
    {
        public string GenerateToken(User user)
        {
            var claims = new List<Claim>
            {
                 new Claim(ClaimTypes.Role, user.Role.Rolecode),
                 new Claim("UserName", user.UserName)
            };
            var hmac = new HMACSHA256();
            var key1 = Convert.ToBase64String(hmac.Key);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetInstance().JWTKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new JwtSecurityToken(
                issuer: "https://localhost:7264",
                audience: "https://localhost:7264",
                claims: claims,
                null,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: creds
                );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
            return token;
        }
    }
}
