using System.Collections.Generic;

namespace RecipeBook.Models
{
  public class Tag
  {
    public Tag()
    {
      JoinEntities = new HashSet<RecipeTag>();
    }
    public int TagId { get; set; }
    public string TagDescription { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<RecipeTag> JoinEntities { get; set; }
  }
}