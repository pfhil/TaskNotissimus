using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using TaskNotissimus.Domain;
using TaskNotissimus.Infrastructure.Persistence.EntityTypeConfigurations;

namespace TaskNotissimus.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Offer> Offers { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new OfferConfiguration());
            builder.ApplyConfiguration(new DateTourConfiguration());
            builder.ApplyConfiguration(new CategoryIdConfiguration());
            builder.ApplyConfiguration(new HallConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
