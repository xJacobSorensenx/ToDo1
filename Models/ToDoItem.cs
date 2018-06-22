using System;

namespace ToDo1.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }

    }
}