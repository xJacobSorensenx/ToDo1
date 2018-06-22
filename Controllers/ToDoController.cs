using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo1.Models;
using ToDo1.Services;

namespace ToDo1.Controllers
{
    public class ToDoController : Controller{

        private IToDoItemService dbctx;

        public ToDoController(IToDoItemService _ctx)
        {
            dbctx=_ctx;
        }
        public async Task<IActionResult> Index(){
            var todoItems = await dbctx.GetIncompletedItemsAsync();

            var model = new ToDoViewModel();
            model.Items=todoItems;

            return View(model);
        }

    }
}