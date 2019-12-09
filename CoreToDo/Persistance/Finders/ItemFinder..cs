using CoreBase.Persistance;
using CoreToDo.Entities;

namespace CoreToDo.Persistance.Finders
{
    public interface IItemFinder : IBaseFinder<Item> { }

    public class ItemFinder : BaseFinder<Item>, IItemFinder
    {
        public ItemFinder(DatabaseContext baseContext) : base(baseContext) { }

    }
}
