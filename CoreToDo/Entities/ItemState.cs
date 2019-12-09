using System;
using CoreBase.Entities;
using CoreToDo.DTOs;

namespace CoreToDo.Entities
{
    public class ItemState : Entity
    {
        public virtual State State { get; set; }

        public DateTime Changed { get; set; }
    }
}
