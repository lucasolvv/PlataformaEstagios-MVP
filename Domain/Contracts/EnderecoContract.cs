namespace PlataformaEstagios.Domain.Contracts
{
    public class EnderecoContract
    {
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? Cep { get; set; }
    }
}
