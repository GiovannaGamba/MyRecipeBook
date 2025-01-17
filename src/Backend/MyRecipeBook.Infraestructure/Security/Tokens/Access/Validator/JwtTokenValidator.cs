using Microsoft.IdentityModel.Tokens;
using MyRecipeBook.Domain.Security.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace MyRecipeBook.Infraestructure.Security.Tokens.Access.Validator
{
    public class JwtTokenValidator : JwtTokenHandler, IAcessTokenValidator
    {
        public readonly string _signingKey;
        public JwtTokenValidator(string signingKey) => _signingKey = signingKey;


        public Guid ValidateAndGetUserIdentifier(string token)
        {
            var validationPatameter = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                IssuerSigningKey = SecurityKey(_signingKey),
                ClockSkew = new TimeSpan(0)
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var principal = tokenHandler.ValidateToken(token, validationPatameter, out _);

            var userIdentifier = principal.Claims.First(c => c.Type == ClaimTypes.Sid).Value;

            return Guid.Parse(userIdentifier);
        }
    }
}
