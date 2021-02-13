using InterdanTest.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterdanTest.Data.SchemaConfigurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> entity)
        {
            entity
                .HasOne(_ => _.Model)
                .WithMany(_ => _.Cars)
                .HasForeignKey(_ => _.ModelId);

            entity
                .HasOne(_ => _.Engine)
                .WithMany(_ => _.Cars)
                .HasForeignKey(_ => _.EngineId);
        }
    }
}
