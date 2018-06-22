using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo1.Models;

namespace ToDo1.Services
{
    public class ToDoItemService : IToDoItemService
    {
        public Task<IEnumerable<ToDoItem>> GetIncompletedItemsAsync()
        {
            IEnumerable<ToDoItem> items = new []{
                new ToDoItem{ Title="Learn da shiet", DueAt=DateTimeOffset.Now.AddDays(1)},
                new ToDoItem{ Title="build apps", DueAt=DateTimeOffset.Now.AddDays(2)},
                new ToDoItem{ Title="build pasta", DueAt=DateTimeOffset.Now.AddDays(3)},
                new ToDoItem{ Title="build the build", DueAt=DateTimeOffset.Now.AddDays(4)}
            };

            return Task.FromResult(items);
            
        }
    }
}