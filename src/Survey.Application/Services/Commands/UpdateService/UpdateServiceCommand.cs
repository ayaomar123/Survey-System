using MediatR;

namespace Survey.Application.Services.Commands.UpdateService
{
    public sealed record UpdateServiceCommand(Guid Id, string Name, string? Description) : IRequest;
    
}
