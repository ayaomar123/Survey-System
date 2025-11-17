using MediatR;
using Microsoft.AspNetCore.Mvc;
using Survey.Api.Requests;
using Survey.Application.Clients.Commands.CreateClient;
using Survey.Application.Clients.Commands.RemoveClient;
using Survey.Application.Clients.Commands.UpdateClient;
using Survey.Application.Clients.Queries.GetClients;

namespace Survey.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await mediator.Send(new GetClientsCommand());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateClientCommand command)
        {
            var id = await mediator.Send(command);

            return Ok(new
            {
                Id = id,
                Message = "Client created successfully"
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateClientRequest request)
        {
            var command = new UpdateClientCommand(id, request.Name, request.Bio);
            await mediator.Send(command);

            return Ok(new { Message = "Client updated successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new RemoveClientCommand(id);

            await mediator.Send(command);

            return Ok(new { Message = "Client deleted successfully" });
        }
    }
}
