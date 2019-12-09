using System;
using System.Collections.Generic;
using CoreBase.Entities;

namespace CoreToDo.Entities
{
    public class Item : EntityWithSoftDelete
    {
        public string Body { get; set; }

        public virtual ICollection<ItemCategory> Categories { get; set; }

        public DateTime Creation { get; set; }

        public virtual ItemState ItemState { get; set; }
    }
}
