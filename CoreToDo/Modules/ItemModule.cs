using Carter;
using CoreBase.Modules;
using CoreBase.Services;
using CoreToDo.DTOs;
using CoreToDo.Entities;
using CoreToDo.Persistance.Finders;

namespace CoreToDo.Modules
{
    public class ItemModule : BaseApiModule<Item, ItemDTO>
    {
        public ItemModule(IBaseModuleService baseModuleService, IItemFinder itemFinder) : base("item", baseModuleService, itemFinder)
        {
            this.RequiresAuthorization();
        }
    }
}
