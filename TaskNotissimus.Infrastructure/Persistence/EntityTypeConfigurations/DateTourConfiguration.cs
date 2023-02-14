using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class DateTourConfiguration : IEntityTypeConfiguration<DateTour>
    {
        public void Configure(EntityTypeBuilder<DateTour> builder)
        {
            builder.HasKey(d => d.Id);
        }
    }
}
