using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
        }
    }
}
