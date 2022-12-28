using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Domain;
using WebApi.Domain.Entities;

namespace WebApi.EF
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("tbl_enderecos");
            builder.HasKey(x => x.EnderecoId);
            builder.Property(x => x.Bairro).HasMaxLength(30).IsRequired();
            builder.Property(x => x.UF).HasMaxLength(2).IsRequired();
            builder.Property(x => x.Cidade).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Cep).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Complemento).HasMaxLength(50).IsRequired();

        }
    }
}
