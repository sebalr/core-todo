using System.Collections.Generic;
using CoreBase.Entities;

namespace CoreToDo.Entities
{
    public class Person : EntityWithSoftDelete
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
