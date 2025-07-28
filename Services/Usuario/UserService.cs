using Microsoft.EntityFrameworkCore;
using PlataformaEstagios.Infrastructure.Data;
using PlataformaEstagios.Domain.Contracts;
using PlataformaEstagios.Domain.Contracts.NewUserContracts;
using PlataformaEstagios.Domain.Enums;
using PlataformaEstagios.Domain.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using PlataformaEstagios.Utils;

namespace PlataformaEstagios.Services.Usuario
{
    public class UserService : IUserServices
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task Login(LoginContract credentials)
        {
            if (credentials == null)
                throw new ArgumentNullException(nameof(credentials));

                        // TODO: Implement login logic

            throw new NotImplementedException();
        }

        public async Task CreateUserAsync(UsuarioCreateContract user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var userExists = await _context.Usuarios
                .AnyAsync(u => u.Email == user.Email || u.NickName == user.Nickname);

            if (userExists) throw new InvalidOperationException("Usuário já existe com este email ou nickname.");

            var usuario = new Domain.Models.Usuario
            {
                NickName = user.Nickname,
                Email = user.Email,
                SenhaHash = PasswordHasher.Encrypt(user.Senha), // implementar hash
                Tipo = ParseTipoUsuario(user.tipoUsuario)
            };

            // 1. Salvar usuário primeiro
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync(); // aqui o UsuarioId é gerado

            // 2. Se for Candidato
            if (user.Candidato != null)
            {
                var candidato = new Candidato
                {
                    UsuarioId = usuario.UsuarioId,
                    Nome = user.Candidato.NomeCompleto,
                    DataNascimento = user.Candidato.DataNascimento,
                    Endereco = MapEndereco(user.Candidato.Endereco)
                };

                _context.Candidatos.Add(candidato);
                await _context.SaveChangesAsync();
            }

            // 3. Se for Empresa
            if (user.Empresa != null)
            {
                var empresa = new Empresa
                {
                    UsuarioId = usuario.UsuarioId,
                    NomeFantasia = user.Empresa.NomeFantasia,
                    Cnpj = user.Empresa.Cnpj,
                    AreaAtuacao = user.Empresa.AreaAtuacao,
                    Endereco = MapEndereco(user.Empresa.Endereco)
                };

                _context.Empresas.Add(empresa);
                await _context.SaveChangesAsync();
            }
        }

        public Task<bool> DeleteCandidatoAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoContract> GetAllCandidatosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoContract> GetCandidatoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco?> GetEnderecoByIdAsync(int enderecoId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCandidatoAsync(int candidatoId, CandidatoCreateContract candidatoUpdateContract)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEmpresaAsync(int empresaId, EmpresaCreateContract empresaUpdateContract)
        {
            throw new NotImplementedException();
        }

        private static TipoUsuario ParseTipoUsuario(string tipo) // passar isso para um helper
        {
            return tipo.ToLower() switch
            {
                "candidato" => TipoUsuario.Candidato,
                "empresa" => TipoUsuario.Empresa,
                _ => throw new ArgumentException($"Tipo de usuário inválido: {tipo}")
            };
        }

        private static Endereco MapEndereco(EnderecoContract contract)
        {
            if (contract == null)
                throw new ArgumentNullException(nameof(contract));

            return new Endereco
            {
                Logradouro = contract.Logradouro ?? string.Empty,
                Complemento = contract.Complemento,
                Bairro = contract.Bairro ?? string.Empty,
                Cidade = contract.Cidade ?? string.Empty,
                UF = contract.UF ?? string.Empty,
                CEP = contract.Cep ?? string.Empty
            };
        }
    }
}
