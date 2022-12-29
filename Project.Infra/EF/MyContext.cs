using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using WebApi.Domain.Entities;

namespace WebApi.EF
{
    public class MyContext : DbContext
    {
        public MyContext()
        {
        }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<FuncionarioPermissao> FuncionarioPermissoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new CargoConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioPermissaoConfiguration());
            modelBuilder.ApplyConfiguration(new PermissaoConfiguration());
        }
    }
}
