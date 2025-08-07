namespace PlataformaEstagios.Application.UseCases.User.CreateUser
{
    public interface ICreateUserUseCase
    {
        Task CreateUserAsync(Domain.Contracts.NewUserContracts.UsuarioCreateContract user);
        //Task<Domain.Contracts.EnderecoContract> GetAllCandidatosAsync();
        //Task<Domain.Contracts.EnderecoContract> GetCandidatoByIdAsync(int id);
        //Task<bool> UpdateCandidatoAsync(int candidatoId, Domain.Contracts.NewUserContracts.CandidatoCreateContract candidatoUpdateContract);
        //Task<bool> UpdateEmpresaAsync(int empresaId, Domain.Contracts.NewUserContracts.EmpresaCreateContract empresaUpdateContract);
        //Task<Domain.Models.Endereco?> GetEnderecoByIdAsync(int enderecoId);
        //Task<bool> DeleteCandidatoAsync(int userId);
    }
}
