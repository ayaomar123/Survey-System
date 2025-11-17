using MediatR;

namespace Survey.Application.Clients.Commands.UpdateClient
{
    public sealed record UpdateClientCommand(Guid Id , string Name, string Bio) : IRequest;
}
