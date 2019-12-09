using CoreBase.DTOs;

namespace CoreToDo.DTOs
{

    public class CategoryDTO : EntityDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
