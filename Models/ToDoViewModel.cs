using System.Collections;
using System.Collections.Generic;

namespace ToDo1.Models
{
    public class ToDoViewModel
    {
        public IEnumerable<ToDoItem> Items { get; set; }
    }
}