using PlataformaEstagios.Domain.Contracts;

namespace PlataformaEstagios.Domain.Dtos
{
    public class CandidateDto
    {
        public string? NomeCompleto { get; set; }
        public string? Cpf { get; set; }
        public string? Curso { get; set; }
        public DateTime? DataNascimento { get; set; }

        public AddressDto? Endereco { get; set; }
    }
}
