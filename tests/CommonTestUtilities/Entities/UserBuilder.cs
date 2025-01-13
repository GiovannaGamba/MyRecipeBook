﻿using Bogus;
using CommonTestUtilities.Cryptography;
using MyRecipeBook.Domain.Entities;

namespace CommonTestUtilities.Entities
{
    public class UserBuilder
    {
        public static (User user, string password) Build()
        {
            var passworEncripter = PasswordEncripterBuilder.Build();

            var password = new Faker().Internet.Password();

            var user = new Faker<User>()
                .RuleFor(user => user.Id, () => 1)
                .RuleFor(user => user.Name, (f) => f.Person.FirstName)
                .RuleFor(user => user.Email, (f, user) => f.Internet.Email(user.Email))
                .RuleFor(user => user.Password, (f) => passworEncripter.Encrypt(password));

            return (user, password);
        }
    }
}
