using System;
using System.Collections.Generic;
using CoreBase.DTOs;

namespace CoreToDo.DTOs
{
    public class ItemDTO : EntityDTO
    {
        public string Body { get; set; }

        public IList<CategoryDTO> Categories { get; set; }

        public DateTime Creation { get; set; }

        public ItemStateDTO ItemState { get; set; }
    }
}
