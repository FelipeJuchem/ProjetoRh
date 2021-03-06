// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RhData;

namespace RhData.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RhDomain.Entities.Candidatos.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Idade")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("VagaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VagaId");

                    b.ToTable("Candidato");
                });

            modelBuilder.Entity("RhDomain.Entities.CandidatosTecnologias.CandidatoTecnologia", b =>
                {
                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("TecnologiaId")
                        .HasColumnType("int");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CandidatoId", "TecnologiaId");

                    b.HasIndex("TecnologiaId");

                    b.ToTable("CandidatoTecnologia");
                });

            modelBuilder.Entity("RhDomain.Entities.Tecnologias.Tecnologia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Tecnologia");
                });

            modelBuilder.Entity("RhDomain.Entities.Vagas.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(6000)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vaga");
                });

            modelBuilder.Entity("RhDomain.Entities.VagasTecnologias.VagaTecnologia", b =>
                {
                    b.Property<int>("TecnologiaId")
                        .HasColumnType("int");

                    b.Property<int>("VagaId")
                        .HasColumnType("int");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("TecnologiaId", "VagaId");

                    b.HasIndex("VagaId");

                    b.ToTable("VagaTecnologia");
                });

            modelBuilder.Entity("RhDomain.Entities.Candidatos.Candidato", b =>
                {
                    b.HasOne("RhDomain.Entities.Vagas.Vaga", "Vaga")
                        .WithMany("Candidatos")
                        .HasForeignKey("VagaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("RhDomain.Entities.CandidatosTecnologias.CandidatoTecnologia", b =>
                {
                    b.HasOne("RhDomain.Entities.Candidatos.Candidato", "Candidato")
                        .WithMany("CandidatosTecnologias")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RhDomain.Entities.Tecnologias.Tecnologia", "Tecnologia")
                        .WithMany("CandidatosTecnologias")
                        .HasForeignKey("TecnologiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");

                    b.Navigation("Tecnologia");
                });

            modelBuilder.Entity("RhDomain.Entities.VagasTecnologias.VagaTecnologia", b =>
                {
                    b.HasOne("RhDomain.Entities.Tecnologias.Tecnologia", "Tecnologia")
                        .WithMany("VagasTecnologias")
                        .HasForeignKey("TecnologiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RhDomain.Entities.Vagas.Vaga", "Vaga")
                        .WithMany("VagasTecnologias")
                        .HasForeignKey("VagaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tecnologia");

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("RhDomain.Entities.Candidatos.Candidato", b =>
                {
                    b.Navigation("CandidatosTecnologias");
                });

            modelBuilder.Entity("RhDomain.Entities.Tecnologias.Tecnologia", b =>
                {
                    b.Navigation("CandidatosTecnologias");

                    b.Navigation("VagasTecnologias");
                });

            modelBuilder.Entity("RhDomain.Entities.Vagas.Vaga", b =>
                {
                    b.Navigation("Candidatos");

                    b.Navigation("VagasTecnologias");
                });
#pragma warning restore 612, 618
        }
    }
}
