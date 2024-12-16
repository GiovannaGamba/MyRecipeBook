using FluentMigrator;

namespace MyRecipeBook.Infraestructure.Migrations.Versions
{
    [Migration(DatabaseVersions.TABLE_USER, "Create table to save the user's information")]
    public class Version0000001 : ForwardOnlyMigration
    {
        public override void Up()
        {
            throw new NotImplementedException();
        }
    }
}
