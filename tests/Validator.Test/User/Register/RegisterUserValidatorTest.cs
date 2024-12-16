using MyRecipeBook.Application.UseCases.User.Register;
using MyRecipeBook.Communication.Requests;

namespace Validator.Test.User.Register
{
    public class RegisterUserValidatorTest
    {
        [Fact]
        public void Sucess()
        {
            var validator = new RegisterUserValidator();

            //Seguir daqui
            var request = new RequestRegisterUserJson
            {
                Email = "email@gmail.com",
            };

            var result = validator.Validate(request);
        }
    }
}
