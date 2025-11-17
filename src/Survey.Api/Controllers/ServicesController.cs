using System.IO.Compression;
using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Survey.Api.Requests;
using Survey.Application.Services.Commands.CreateService;
using Survey.Application.Services.Commands.DeleteService;
using Survey.Application.Services.Commands.UpdateService;
using Survey.Application.Services.Queries.GetServices;

namespace Survey.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await mediator.Send(new GetServicesQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceCommand command)
        {
            var id = await mediator.Send(command);

            return Ok(new
            {
                Id = id,
                Message = "Service created successfully"
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateServiceRequest request)
        {
            var command = new UpdateServiceCommand(id,request.Name, request.Description);
            await mediator.Send(command);

            return Ok(new { Message = "Service updated successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteServiceCommand(id);

            await mediator.Send(command);

            return Ok(new { Message = "Service deleted successfully" });
        }
    }
}
