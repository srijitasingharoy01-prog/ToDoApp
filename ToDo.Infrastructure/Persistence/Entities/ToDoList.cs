using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Infrastructure.Persistence.Entities
{
    public class ToDoList : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public ICollection<TodoItem> TodoItems { get; set; }
    }
}
