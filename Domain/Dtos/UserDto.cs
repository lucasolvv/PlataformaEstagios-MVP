﻿namespace PlataformaEstagios.Domain.Dtos
{
    public class UserDto
    {
        public string Nickname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        // Tipo do usuário: "Candidate", "Enterprise" ou "Outro"
        public string? TipoUsuario { get; set; }

    }
}
