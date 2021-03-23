using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RecipeBook.Models
{
  public class RecipeBookContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Recipe> Recipes { get; set; }
    public  DbSet<Tag> Tags { get; set; }
    public DbSet<RecipeTag> RecipeTag { get; set; }
    public RecipeBookContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}