using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Todo.Adapter.Controllers.Base;
using Todo.Adapter.Models.TodoItem.Create;
using Todo.Application.TodoItem.Commands.CreateTodoItem;

namespace Todo.Adapter.Controllers
{
    public class TodoItemController : ApiController
    {
        [HttpPost]
        public async Task<CreateTodoItemOutput> CreateTodoItem (CreateTodoItemInput createTodoItemInput)
        {
            CreateTodoItemCommandResponse createTodoItemCommandResponse = await Mediator.Send(new CreateTodoItemCommand());
            return new CreateTodoItemOutput();
        }
    }
}
