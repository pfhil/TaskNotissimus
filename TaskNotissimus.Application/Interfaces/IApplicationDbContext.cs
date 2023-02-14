using Microsoft.EntityFrameworkCore;
using TaskNotissimus.Domain;

namespace Notes.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Offer> Offers { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
