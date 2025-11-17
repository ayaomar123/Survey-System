using MediatR;
using Survey.Application.Services.Queries.Dtos;

namespace Survey.Application.Services.Queries.GetServices
{
    public sealed record GetServicesQuery : IRequest<List<GetServicesResponse>>
    {
    }
}
