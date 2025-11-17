using MediatR;
using Microsoft.EntityFrameworkCore;
using Survey.Application.Clients.Queries.Dtos;
using Survey.Application.Interfaces;

namespace Survey.Application.Clients.Queries.GetClients
{
    public class GetClientsCommandHandler(IAppDbContext context) : IRequestHandler<GetClientsCommand, List<GetClientsResponse>>
    {
        public async Task<List<GetClientsResponse>> Handle(GetClientsCommand request, CancellationToken ct)
        {
            var clients = await context.Clients
                .Select(s => new GetClientsResponse
                {
                    Id = s.Id,
                    Name = s.Name!,
                    Bio = s.Bio,
                    CreatedAt = s.CreatedAt
                })
                .ToListAsync(ct);

            return clients;
        }
    }
}
