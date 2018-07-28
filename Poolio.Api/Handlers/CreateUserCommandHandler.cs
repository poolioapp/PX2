using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Poolio.Api.Commands.User;

namespace Poolio.Api.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        public Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
