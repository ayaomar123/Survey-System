using MediatR;
using Survey.Application.Interfaces;
using Survey.Domain.Entities.Services;

namespace Survey.Application.Services.Commands.CreateService
{
    public class CreateServiceCommandHandler(IAppDbContext context) : IRequestHandler<CreateServiceCommand, Guid>
    {
        public async Task<Guid> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = Service.Create(request.Name, request.Description);

            await context.Services.AddAsync(service, cancellationToken);

            await context.SaveChangesAsync(cancellationToken);

            return service.Id;
        }
    }
}
