using Microsoft.EntityFrameworkCore;
using RhDomain.Entities.Candidatos;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using RhDomain.Entities.VagasTecnologias;
using System;

namespace RhData
{
    public class DataContext : DbContext
    {

        public DataContext()
        {
        }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Tecnologia> Tecnologia { get; set; }
        public DbSet<Vaga> Vaga { get; set; }
        public DbSet<VagaTecnologia> VagasTecnologias  { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RHDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var candidato = modelBuilder.Entity<Candidato>();

            candidato.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(250);

            candidato.Property(x => x.Sobrenome)
                .IsRequired()
                .HasMaxLength(250);

            candidato.Property(x => x.Idade)
                .IsRequired();

            candidato.Property(x => x.Cpf)
                .IsRequired();

            candidato.HasOne(x => x.Vaga)
                .WithMany(x => x.Candidatos)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.VagaId);

            var tecnologia = modelBuilder.Entity<Tecnologia>();

            tecnologia.Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(250);

            tecnologia.Property(x => x.Peso)
                .IsRequired();

            var vaga = modelBuilder.Entity<Vaga>();

            vaga.Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(6000);

            var vagaTecnologia = modelBuilder.Entity<VagaTecnologia>();

            vagaTecnologia.HasKey(x => new { x.TecnologiaId, x.VagaId });

            vagaTecnologia.HasOne(x => x.Tecnologias)
                .WithMany(x => x.VagasTecnologias)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.TecnologiaId);

            vagaTecnologia.HasOne(x => x.Vagas)
                .WithMany(x => x.VagasTecnologias)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.VagaId);

        }
    }
}
