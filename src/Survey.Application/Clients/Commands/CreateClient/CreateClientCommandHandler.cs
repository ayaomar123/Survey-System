using MediatR;
using Survey.Application.Interfaces;
using Survey.Domain.Entities;

namespace Survey.Application.Clients.Commands.CreateClient
{
    public class CreateClientCommandHandler(IAppDbContext context) : IRequestHandler<CreateClientCommand, Guid>
    {
        public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var client = Client.Create(
               request.Name,
               request.Bio);

            context.Clients.Add(client);

            await context.SaveChangesAsync(cancellationToken);

            return client.Id;


        }
    }
}
