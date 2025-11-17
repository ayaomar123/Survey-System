using Microsoft.EntityFrameworkCore;
using Survey.Domain.Entities.Services;

namespace Survey.Application.Interfaces
{
    public interface IAppDbContext
    {
        public DbSet<Service> Services { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
