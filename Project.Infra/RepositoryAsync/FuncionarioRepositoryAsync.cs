using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infra.RepositoryAsync
{
    public class FuncionarioRepositoryAsync : BaseRepository<Funcionario>, IFuncionarioRepositoryAsync
    {
        public FuncionarioRepositoryAsync(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
