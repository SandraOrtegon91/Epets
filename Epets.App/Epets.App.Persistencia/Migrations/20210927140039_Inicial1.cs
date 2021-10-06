using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Epets.App.Persistencia.Migrations
{
    public partial class Inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Especialidad",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TarjetaProfesional",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nit = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Historia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Medicamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMascota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorOjos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorPiel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatura = table.Column<float>(type: "real", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropietarioId = table.Column<int>(type: "int", nullable: true),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    TipoAnimal = table.Column<int>(type: "int", nullable: false),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mascotas_Historia_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_Personas_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_Personas_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecomendacionesCuidado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecomendacionesCuidado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecomendacionesCuidado_Historia_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignoVital",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor_signo = table.Column<float>(type: "real", nullable: false),
                    Signo = table.Column<int>(type: "int", nullable: false),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignoVital", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignoVital_Historia_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudVisita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MascotaId = table.Column<int>(type: "int", nullable: true),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PropietarioId = table.Column<int>(type: "int", nullable: true),
                    NombreMascotaId = table.Column<int>(type: "int", nullable: true),
                    TipoAnimal = table.Column<int>(type: "int", nullable: false),
                    Especialidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudVisita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudVisita_Mascotas_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudVisita_Mascotas_NombreMascotaId",
                        column: x => x.NombreMascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudVisita_Personas_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EmpresaId",
                table: "Personas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_HistoriaId",
                table: "Mascotas",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_MedicoId",
                table: "Mascotas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_PropietarioId",
                table: "Mascotas",
                column: "PropietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_RecomendacionesCuidado_HistoriaId",
                table: "RecomendacionesCuidado",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SignoVital_HistoriaId",
                table: "SignoVital",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisita_MascotaId",
                table: "SolicitudVisita",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisita_NombreMascotaId",
                table: "SolicitudVisita",
                column: "NombreMascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisita_PropietarioId",
                table: "SolicitudVisita",
                column: "PropietarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Empresa_EmpresaId",
                table: "Personas",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Empresa_EmpresaId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "RecomendacionesCuidado");

            migrationBuilder.DropTable(
                name: "SignoVital");

            migrationBuilder.DropTable(
                name: "SolicitudVisita");

            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Historia");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EmpresaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Especialidad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TarjetaProfesional",
                table: "Personas");
        }
    }
}
