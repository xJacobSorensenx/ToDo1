using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo1.Models;

namespace ToDo1.Services
{
    public interface IToDoItemService
    {
        Task<IEnumerable<ToDoItem>> GetIncompletedItemsAsync();
    }
}