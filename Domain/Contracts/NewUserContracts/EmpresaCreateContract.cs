namespace PlataformaEstagios.Domain.Contracts.NewUserContracts
{
    public class EmpresaCreateContract
    {
        public string? NomeFantasia { get; set; }
        public string? Cnpj { get; set; }
        public string? AreaAtuacao { get; set; }

        public EnderecoContract? Endereco { get; set; }
    }
}
