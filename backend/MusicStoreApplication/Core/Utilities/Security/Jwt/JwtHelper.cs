using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilities.Security.Encyption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace Core.Utilities.Security.Jwt
{
    public class JwtHelper
        : ITokenHelper
    {
        private TokenOptions _tokenOptions;
        private IConfiguration Configuration { get; }
        private DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }
        public AccessToken CreateToken(User user, List<OperationClaim> claims)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(signingCredentials, claims, user);
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Expiration = _accessTokenExpiration,
                Token = token
            };
        }

        private JwtSecurityToken CreateJwtSecurityToken(SigningCredentials signingCredentials, List<OperationClaim> claims, User user)
        {
            var jwtSecurityToken = new JwtSecurityToken(
                 issuer: _tokenOptions.Issuer,
                 audience: _tokenOptions.Audience,
                 notBefore: DateTime.Now,
                 expires: _accessTokenExpiration,
                 signingCredentials: signingCredentials,
                 claims: SetClaims(user, claims)
                );

            return jwtSecurityToken;
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claimList = new List<Claim>();
            claimList.AddEmail(user.Email);
            claimList.AddName($"{user.FirstName} {user.LastName}");
            claimList.AddNameIdentifier(user.Id.ToString());
            claimList.AddRoles(operationClaims.Select(x => x.Name).ToArray());
            return claimList;
        }
    }
}
