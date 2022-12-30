using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

namespace WebApi.EF
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("tbl_funcionarios");
            builder.HasKey(o => o.FuncionarioId);
            builder.Property(t => t.FuncionarioId).ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.Nome).HasMaxLength(30).IsRequired();
            builder.Property(t => t.Salario).HasPrecision(6, 2).IsRequired();
            builder.Property(t => t.Idade).IsRequired();

        }
    }
}
