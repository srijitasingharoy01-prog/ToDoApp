using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToDo.Infrastructure.Persistence.Entities
{
    public class ToDoItem : BaseAuditableEntity
    {
        public Guid ToDoListId { get; set;  }
        public ToDoList ToDoList { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ReminderDate { get; set; }
        public DateTime? CompletedAt { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<ToDoItemTag> ToDoItemTags { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
