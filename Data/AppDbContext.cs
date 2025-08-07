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

        public DbSet<User> Usuarios { get; set; }
        public DbSet<Candidate> Candidatos { get; set; }
        public DbSet<Enterprise> Empresas { get; set; }
        public DbSet<Course> Cursos { get; set; }
        public DbSet<Vacancy> Vagas { get; set; }
        public DbSet<Domain.Models.Application> Candidaturas { get; set; }
        public DbSet<Address> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Models.Application>()
                .HasOne(c => c.Vaga)
                .WithMany(v => v.Candidaturas)
                .HasForeignKey(c => c.VagaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Domain.Models.Application>()
                .HasOne(c => c.Candidato)
                .WithMany(c => c.Candidaturas)
                .HasForeignKey((object c) => c.CandidatoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
