using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Todo.Application.TodoItem.Commands.CreateTodoItem
{
    public class CreateTodoItemCommandResponse
    {

    }

    public class CreateTodoItemCommand : IRequest<CreateTodoItemCommandResponse>
    {

    }

    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, CreateTodoItemCommandResponse>
    {
        public async Task<CreateTodoItemCommandResponse> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            return new CreateTodoItemCommandResponse();
        }
    }
}
