﻿using Microsoft.Extensions.Configuration;

namespace MyRecipeBook.Infraestructure.Extensions
{
    public static class ConfigurationExtension
    {
        public static bool IsUnitTestEnviroment(this IConfiguration configuration)
        {
            return configuration.GetValue<bool>("InMemoryTest");
        }
        public static string ConnectionString(this IConfiguration configuration)
        {
            var databaseType = configuration.GetConnectionString("Connection");
            return configuration.GetConnectionString("Connection")!;
        }
    }
}
