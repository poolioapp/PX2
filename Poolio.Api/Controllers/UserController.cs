using MediatR;
using Microsoft.AspNetCore.Mvc;
using Poolio.Api.Commands.User;
using Poolio.Api.RequestModels.User;

namespace Poolio.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // POST api/user
        [HttpPost]
        public async void Post([FromBody]CreateUserRequestModel model)
        {
            var command = new CreateUserCommand(model.Email, model.Password);
            await _mediator.Send(command);
        }
    }
}