using Project.Domain.Entities;

namespace WebApi.Domain.Entities
{
    public class FuncionarioPermissao
    {
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public int PermissaoId { get; set; }
        public virtual Permissao Permissao { get; set; }
    }
}
