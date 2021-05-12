using Microsoft.EntityFrameworkCore.Migrations;

namespace RhData.Migrations
{
    public partial class patchrelacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vagaTecnologia_Tecnologia_TecnologiaId",
                table: "vagaTecnologia");

            migrationBuilder.DropForeignKey(
                name: "FK_vagaTecnologia_Vaga_VagaId",
                table: "vagaTecnologia");

            migrationBuilder.DropTable(
                name: "CandidatoTecnologia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vagaTecnologia",
                table: "vagaTecnologia");

            migrationBuilder.RenameTable(
                name: "vagaTecnologia",
                newName: "VagasTecnologias");

            migrationBuilder.RenameIndex(
                name: "IX_vagaTecnologia_VagaId",
                table: "VagasTecnologias",
                newName: "IX_VagasTecnologias_VagaId");

            migrationBuilder.AddColumn<int>(
                name: "CandidatoId",
                table: "Tecnologia",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VagasTecnologias",
                table: "VagasTecnologias",
                columns: new[] { "TecnologiaId", "VagaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Tecnologia_CandidatoId",
                table: "Tecnologia",
                column: "CandidatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tecnologia_Candidato_CandidatoId",
                table: "Tecnologia",
                column: "CandidatoId",
                principalTable: "Candidato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VagasTecnologias_Tecnologia_TecnologiaId",
                table: "VagasTecnologias",
                column: "TecnologiaId",
                principalTable: "Tecnologia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VagasTecnologias_Vaga_VagaId",
                table: "VagasTecnologias",
                column: "VagaId",
                principalTable: "Vaga",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tecnologia_Candidato_CandidatoId",
                table: "Tecnologia");

            migrationBuilder.DropForeignKey(
                name: "FK_VagasTecnologias_Tecnologia_TecnologiaId",
                table: "VagasTecnologias");

            migrationBuilder.DropForeignKey(
                name: "FK_VagasTecnologias_Vaga_VagaId",
                table: "VagasTecnologias");

            migrationBuilder.DropIndex(
                name: "IX_Tecnologia_CandidatoId",
                table: "Tecnologia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VagasTecnologias",
                table: "VagasTecnologias");

            migrationBuilder.DropColumn(
                name: "CandidatoId",
                table: "Tecnologia");

            migrationBuilder.RenameTable(
                name: "VagasTecnologias",
                newName: "vagaTecnologia");

            migrationBuilder.RenameIndex(
                name: "IX_VagasTecnologias_VagaId",
                table: "vagaTecnologia",
                newName: "IX_vagaTecnologia_VagaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vagaTecnologia",
                table: "vagaTecnologia",
                columns: new[] { "TecnologiaId", "VagaId" });

            migrationBuilder.CreateTable(
                name: "CandidatoTecnologia",
                columns: table => new
                {
                    CandidatoId = table.Column<int>(type: "int", nullable: false),
                    TecnologiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoTecnologia", x => new { x.CandidatoId, x.TecnologiaId });
                    table.ForeignKey(
                        name: "FK_CandidatoTecnologia_Candidato_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CandidatoTecnologia_Tecnologia_TecnologiaId",
                        column: x => x.TecnologiaId,
                        principalTable: "Tecnologia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoTecnologia_TecnologiaId",
                table: "CandidatoTecnologia",
                column: "TecnologiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_vagaTecnologia_Tecnologia_TecnologiaId",
                table: "vagaTecnologia",
                column: "TecnologiaId",
                principalTable: "Tecnologia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vagaTecnologia_Vaga_VagaId",
                table: "vagaTecnologia",
                column: "VagaId",
                principalTable: "Vaga",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
