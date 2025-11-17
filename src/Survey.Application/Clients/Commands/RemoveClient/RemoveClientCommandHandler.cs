using MediatR;
using Survey.Application.Interfaces;

namespace Survey.Application.Clients.Commands.RemoveClient
{
    public class RemoveClientCommandHandler(IAppDbContext context) : IRequestHandler<RemoveClientCommand>
    {
        public async Task Handle(RemoveClientCommand request, CancellationToken ct)
        {
            var client = await context.Clients
                .FindAsync(request.Id, ct);

            if (client == null)
                throw new Exception("client not found.");

            context.Clients.Remove(client);

            await context.SaveChangesAsync(ct);
        }
    }
}
