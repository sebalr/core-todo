using CoreBase.Persistance;
using CoreToDo.Entities;

namespace CoreToDo.Persistance.Finders
{
    public interface ICategoryFinder : IBaseFinder<Category> { }

    public class CategoryFinder : BaseFinder<Category>, ICategoryFinder
    {
        public CategoryFinder(DatabaseContext baseContext) : base(baseContext) { }

    }
}
