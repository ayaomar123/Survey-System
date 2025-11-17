using MediatR;

namespace Survey.Application.Clients.Commands.RemoveClient
{
    public sealed record RemoveClientCommand(Guid Id) : IRequest;
}
