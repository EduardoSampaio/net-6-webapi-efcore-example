namespace WebApi.Domain.Entities
{
    public class Permissao
    {
        public int PermissaoId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<FuncionarioPermissao> FuncionarioPermissaos { get; set; }
    }
}
