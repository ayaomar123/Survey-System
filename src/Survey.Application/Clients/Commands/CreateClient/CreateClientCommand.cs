using MediatR;

namespace Survey.Application.Clients.Commands.CreateClient
{
    public sealed record CreateClientCommand (string Name, string? Bio) : IRequest<Guid>;
}
