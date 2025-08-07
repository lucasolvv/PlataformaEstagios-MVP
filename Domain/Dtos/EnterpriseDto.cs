using PlataformaEstagios.Domain.Contracts;

namespace PlataformaEstagios.Domain.Dtos
{
    public class EnterpriseDto
    {
        public string? NomeFantasia { get; set; }
        public string? Cnpj { get; set; }
        public string? AreaAtuacao { get; set; }

        public AddressDto? Endereco { get; set; }
    }
}
