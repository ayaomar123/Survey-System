using MediatR;

namespace Survey.Application.Services.Commands.CreateService
{
    public sealed record CreateServiceCommand(string Name, string? Description) : IRequest<Guid>;
}
