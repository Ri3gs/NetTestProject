using InterdanTest.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterdanTest.Data.SchemaConfigurations
{
    public class CarColorConfiguration : IEntityTypeConfiguration<CarColor>
    {
        public void Configure(EntityTypeBuilder<CarColor> entity)
        {
            entity
                .HasOne(_ => _.Car)
                .WithMany(_ => _.Colors)
                .HasForeignKey(_ => _.CarId);

            entity
                .HasOne(_ => _.Color)
                .WithMany(_ => _.CarColors)
                .HasForeignKey(_ => _.ColorId);
        }
    }
}
