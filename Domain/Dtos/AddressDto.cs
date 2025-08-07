namespace PlataformaEstagios.Domain.Contracts
{
    public class AddressDto
    {
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? Cep { get; set; }
    }
}
