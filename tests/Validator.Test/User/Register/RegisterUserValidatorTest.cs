using MyRecipeBook.Application.UseCases.User.Register;

namespace Validator.Test.User.Register
{
    public class RegisterUserValidatorTest
    {
        [Fact]
        public async Task Success()
        {
            var validator = new RegisterUserValidator();

            var result = validator.Validate(request);
        }
    }
}
