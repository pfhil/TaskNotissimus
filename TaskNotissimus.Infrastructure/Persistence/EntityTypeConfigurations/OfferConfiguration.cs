using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(offer => offer.Id);
            builder.HasIndex(offer => offer.Id).IsUnique();
            builder.Property(e => e.Id).ValueGeneratedNever();
        }
    }
}
