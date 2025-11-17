using MediatR;
using Microsoft.EntityFrameworkCore;
using Survey.Application.Interfaces;

namespace Survey.Application.Services.Commands.UpdateService
{
    public class UpdateServiceCommandHandler(IAppDbContext context) : IRequestHandler<UpdateServiceCommand>
    {
        public async Task Handle(UpdateServiceCommand request, CancellationToken ct)
        {
            var service = await context.Services
                .FirstOrDefaultAsync(s => s.Id == request.Id, ct);

            if (service == null)
                throw new Exception("Service not found.");

            service.Update(request.Name, request.Description);

            await context.SaveChangesAsync(ct);
        }
    }
}
