using Dapper;
using MySqlConnector;

namespace MyRecipeBook.Infraestructure.Migrations
{
    public static class DataBaseMigration
    {
        public static void Migrate(string connectionString)
        {
            EnsureDatabaseCreated_MySql(connectionString);
        }

        private static void EnsureDatabaseCreated_MySql(string connectionString)
        {
            var connectionStringBuilder = new MySqlConnectionStringBuilder(connectionString);

            var databaseName = connectionStringBuilder.Database;

            connectionStringBuilder.Remove("Database");

            using var dbConnection = new MySqlConnection(connectionStringBuilder.ConnectionString);

            var parameters = new DynamicParameters();
            parameters.Add("name", databaseName);

            var records = dbConnection.Query("SELECT * FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @name", parameters);

            if (records.Any() == false)
                dbConnection.Execute($"CREATE DATABASE {databaseName}");
        }
    }
}
