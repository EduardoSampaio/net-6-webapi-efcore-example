using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Domain.Entities;

namespace WebApi.EF
{
    public class PermissaoConfiguration : IEntityTypeConfiguration<Permissao>
    {
        public void Configure(EntityTypeBuilder<Permissao> builder)
        {
            builder.ToTable("tbl_permissoes");
            builder.HasKey(x => x.PermissaoId);
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
        }
    }
}
