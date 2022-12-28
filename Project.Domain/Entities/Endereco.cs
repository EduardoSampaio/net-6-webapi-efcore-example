using Project.Domain.Entities;

namespace WebApi.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
