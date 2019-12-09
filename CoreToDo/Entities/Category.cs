using CoreBase.Entities;

namespace CoreToDo.Entities
{
    public class Category : EntityWithSoftDelete
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
