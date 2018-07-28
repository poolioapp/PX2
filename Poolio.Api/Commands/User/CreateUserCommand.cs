using MediatR;

namespace Poolio.Api.Commands.User
{
    public class CreateUserCommand : IRequest
    {
        public string Email { get; }
        public string Password { get; }

        public CreateUserCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
