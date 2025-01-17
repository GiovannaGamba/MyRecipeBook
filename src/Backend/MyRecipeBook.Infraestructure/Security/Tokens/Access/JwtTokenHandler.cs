using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MyRecipeBook.Infraestructure.Security.Tokens.Access
{
    public abstract class JwtTokenHandler
    {
        protected SymmetricSecurityKey SecurityKey(string _signingKey)
        {
            var bytes = Encoding.UTF8.GetBytes(_signingKey);

            return new SymmetricSecurityKey(bytes);
        }
    }
}
