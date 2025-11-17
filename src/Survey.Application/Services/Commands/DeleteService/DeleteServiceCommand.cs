using MediatR;

namespace Survey.Application.Services.Commands.DeleteService
{
    public sealed record DeleteServiceCommand(Guid Id) : IRequest;
}
