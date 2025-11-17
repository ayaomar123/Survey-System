using MediatR;
using Microsoft.EntityFrameworkCore;
using Survey.Application.Interfaces;

namespace Survey.Application.Clients.Commands.UpdateClient
{
    public class UpdateClientCommandHandler(IAppDbContext context) : IRequestHandler<UpdateClientCommand>
    {
        public async Task Handle(UpdateClientCommand request, CancellationToken ct)
        {
            var client = await context.Clients
                .FirstOrDefaultAsync(s => s.Id == request.Id, ct);

            if (client == null)
                throw new Exception("client not found.");

            client.Update(request.Name, request.Bio);

            await context.SaveChangesAsync(ct);
        }
    }
}
