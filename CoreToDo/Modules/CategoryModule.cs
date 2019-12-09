using CoreBase.Modules;
using CoreBase.Services;
using CoreToDo.DTOs;
using CoreToDo.Entities;
using CoreToDo.Persistance.Finders;

namespace CoreToDo.Modules
{
    public class CategoryModule : BaseApiModule<Category, CategoryDTO>
    {
        public CategoryModule(IBaseModuleService baseModuleService, ICategoryFinder categoryFinder) : base("category", baseModuleService, categoryFinder)
        {

        }
    }
}
