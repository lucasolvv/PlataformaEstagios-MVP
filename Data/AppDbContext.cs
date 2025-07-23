using Microsoft.EntityFrameworkCore;
using PlataformaEstagios.Domain.Models;

namespace PlataformaEstagios.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Candidatura> Candidaturas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
