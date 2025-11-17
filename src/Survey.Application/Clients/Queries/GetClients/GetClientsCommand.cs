using MediatR;
using Survey.Application.Clients.Queries.Dtos;

namespace Survey.Application.Clients.Queries.GetClients
{
    public class GetClientsCommand : IRequest<List<GetClientsResponse>>
    {
    }
}
