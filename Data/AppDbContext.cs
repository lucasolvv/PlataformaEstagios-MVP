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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacionamento 1:1 entre Usuario e Endereco
            modelBuilder.Entity<Endereco>()
                .HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            // Candidato -> Usuario (1:1)
            modelBuilder.Entity<Candidato>()
                .HasOne(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            // Candidato -> Curso (N:1)
            modelBuilder.Entity<Candidato>()
                .HasOne(c => c.Curso)
                .WithMany(cu => cu.Candidatos)
                .HasForeignKey(c => c.CursoId)
                .OnDelete(DeleteBehavior.SetNull);

            // Empresa -> Usuario (1:1)
            modelBuilder.Entity<Empresa>()
                .HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            // Vaga -> Empresa (N:1)
            modelBuilder.Entity<Vaga>()
                .HasOne(v => v.Empresa)
                .WithMany(e => e.Vagas)
                .HasForeignKey(v => v.EmpresaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Candidatura -> Vaga (N:1)
            modelBuilder.Entity<Candidatura>()
                .HasOne(ca => ca.Vaga)
                .WithMany(v => v.Candidaturas)
                .HasForeignKey(ca => ca.VagaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Candidatura -> Candidato (N:1)
            modelBuilder.Entity<Candidatura>()
                .HasOne(ca => ca.Candidato)
                .WithMany(c => c.Candidaturas)
                .HasForeignKey(ca => ca.CandidatoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Candidato -> Endereco (1:1)
            modelBuilder.Entity<Candidato>()
                .HasOne(c => c.Endereco)
                .WithOne()
                .HasForeignKey<Candidato>(c => c.Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Empresa -> Endereco (1:1)
            modelBuilder.Entity<Empresa>()
                .HasOne(e => e.Endereco)
                .WithOne()
                .HasForeignKey<Empresa>(e => e.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
