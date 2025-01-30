using MyRecipeBook.Domain.Entities;
using MyRecipeBook.Domain.Repositories.Recipe;
using MyRecipeBook.Infraestructure.DataAccess;
namespace MyRecipeBook.Infrastructure.DataAccess.Repositories;
public sealed class RecipeRepository : IRecipeWriteOnlyRepository
{
    private readonly MyRecipeBookDbContext _dbContext;
    public RecipeRepository(MyRecipeBookDbContext dbContext) => _dbContext = dbContext;
    public async Task Add(Recipe recipe) => await _dbContext.Recipes.AddAsync(recipe);
}