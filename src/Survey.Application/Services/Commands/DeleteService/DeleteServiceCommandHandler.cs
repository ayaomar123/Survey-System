using MediatR;
using Survey.Application.Interfaces;

namespace Survey.Application.Services.Commands.DeleteService
{
    public class DeleteServiceCommandHandler(IAppDbContext context) : IRequestHandler<DeleteServiceCommand>
    {
        public async Task Handle(DeleteServiceCommand request, CancellationToken ct)
        {
            var service = await context.Services
                .FindAsync(request.Id, ct);

            if (service is null)
            {
                if (service == null)
                    throw new Exception("Service not found.");
            }

            context.Services.Remove(service);

            await context.SaveChangesAsync(ct);
        }
    }
}
