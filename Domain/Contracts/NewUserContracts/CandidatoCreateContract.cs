namespace PlataformaEstagios.Domain.Contracts.NewUserContracts
{
    public class CandidatoCreateContract
    {
        public string? NomeCompleto { get; set; }
        public string? Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }

        public EnderecoContract? Endereco { get; set; }
    }
}
