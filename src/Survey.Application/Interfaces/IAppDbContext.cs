using Microsoft.EntityFrameworkCore;
using Survey.Domain.Entities;
using Survey.Domain.Entities.Services;

namespace Survey.Application.Interfaces
{
    public interface IAppDbContext
    {
        public DbSet<Service> Services { get; }
        public DbSet<Client> Clients { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
