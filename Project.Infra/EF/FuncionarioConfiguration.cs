using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;
using WebApi.Domain;

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
            builder.Property(t => t.DataEntrada).IsRequired();
            builder.Property(t => t.DataSaida);
            builder.Property(t => t.Ativo).IsRequired();
            builder.Property(t => t.Idade).IsRequired();
            //builder.Property(t => t.Sexo).IsRequired();
            //builder.HasOne(r => r.Cargo)
            //    .WithMany(r => r.Funcionarios)
            //    .HasForeignKey(r => r.CargoId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(x => x.Endereco).WithOne(x => x.Funcionario).HasForeignKey<Endereco>(b => b.EnderecoId);

        }
    }
}
