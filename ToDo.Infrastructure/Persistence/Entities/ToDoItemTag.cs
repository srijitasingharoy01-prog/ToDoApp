using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Infrastructure.Persistence.Entities
{
    public class ToDoItemTag
    {
        public Guid Id { get; set; }
        public Guid TodoItemId { get; set; }
        public TodoItem TodoItem { get; set; }

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
