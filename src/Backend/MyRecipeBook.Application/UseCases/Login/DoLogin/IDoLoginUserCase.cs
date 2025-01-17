﻿using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.Login.DoLogin
{
    public interface IDoLoginUserCase
    {
        public Task<ResponseRegisteredUserJson> Execute(RequestLoginJson request);
    }
}
