using MediatR;
using Microsoft.EntityFrameworkCore;
using Survey.Application.Interfaces;
using Survey.Application.Services.Queries.Dtos;

namespace Survey.Application.Services.Queries.GetServices
{
    public class GetServicesQueryHandler(IAppDbContext context) : IRequestHandler<GetServicesQuery, List<GetServicesResponse>>
    {
        public async Task<List<GetServicesResponse>> Handle(GetServicesQuery query, CancellationToken ct)
        {
            var services = await context.Services
                .Select(s => new GetServicesResponse
                {
                    Id = s.Id,
                    Name = s.Name!,
                    Description = s.Description,
                    CreatedAt = s.CreatedAt
                })
                .ToListAsync(ct);

            return services;
        }
    }
}
