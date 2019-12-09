using System.Collections.Generic;
using CoreBase.DTOs;

namespace CoreToDo.DTOs
{

    public class PersonDTO : EntityDTO
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public IList<ItemDTO> Items { get; set; }
    }
}
