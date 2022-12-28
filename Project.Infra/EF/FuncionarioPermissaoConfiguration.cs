using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Domain.Entities;

namespace WebApi.EF
{
    public class FuncionarioPermissaoConfiguration : IEntityTypeConfiguration<FuncionarioPermissao>
    {
        public void Configure(EntityTypeBuilder<FuncionarioPermissao> builder)
        {
            builder.ToTable("tbl_funcionario_permissao");
            builder.HasKey(e => new { e.FuncionarioId, e.PermissaoId });
          //  builder.HasOne(e => e.Funcionario).WithMany(e => e.FuncionarioPermissaos).HasForeignKey(e => e.FuncionarioId);
            builder.HasOne(e => e.Permissao).WithMany(e => e.FuncionarioPermissaos).HasForeignKey(e => e.PermissaoId);
        }
    }
}
