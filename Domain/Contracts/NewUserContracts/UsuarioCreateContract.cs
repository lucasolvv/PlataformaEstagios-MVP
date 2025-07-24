namespace PlataformaEstagios.Domain.Contracts.NewUserContracts
{
    public class UsuarioCreateContract
    {
        public string Nickname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        // Tipo do usuário: "Candidato", "Empresa" ou "Outro"
        public string tipoUsuario { get; set; }

        // Dados adicionais opcionais (um ou outro)
        public CandidatoCreateContract? Candidato { get; set; }
        public EmpresaCreateContract? Empresa { get; set; }
    }

    //public enum TipoUsuario
    //{
    //    Candidato,
    //    Empresa,
    //}

}
