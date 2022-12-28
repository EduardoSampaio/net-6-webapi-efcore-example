using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

namespace WebApi.EF
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("tbl_cargos");
            builder.HasKey(x => x.CargoId);
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
        }
    }
}
