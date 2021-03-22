using System.Collections.Generic;

namespace RecipeBook.Models
{
  public class Recipe
  {
    public Recipe()
    {
      JoinEntities = new HashSet<RecipeTag>();
    }
    public int RecipeId { get; set; }
    public string RecipeName { get; set; }
    public string RecipeDescription { get; set; }
    public string RecipeInstructions { get; set; }
    public float RecipeRaiting { get; set; }
    public virtual ApplicationUser { get; set; }
    public virtual ICollection<RecipeTag> JoinEntities { get; }
  }
}