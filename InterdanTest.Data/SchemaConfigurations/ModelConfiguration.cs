using InterdanTest.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterdanTest.Data.SchemaConfigurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> entity)
        {
            entity
                .HasOne(_ => _.Brand)
                .WithMany(_ => _.Models)
                .HasForeignKey(_ => _.BarndId);
        }
    }
}
