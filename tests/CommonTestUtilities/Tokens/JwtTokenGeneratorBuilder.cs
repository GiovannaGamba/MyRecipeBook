using MyRecipeBook.Domain.Security.Tokens;
using MyRecipeBook.Infraestructure.Security.Tokens.Access.Generator;

namespace CommonTestUtilities.Tokens
{
    public class JwtTokenGeneratorBuilder
    {
        public static IAcessTokenGenerator Build() => new JwtTokenGenerator(expirationTimeMinutes: 5, signingKey: "tttttttttttttttttttttttttttttttt");
    }
}
