namespace MyRecipeBook.Domain.Security.Tokens
{
    public interface IAcessTokenValidator
    {
        public Guid ValidateAndGetUserIdentifier(string token);
    }
}
