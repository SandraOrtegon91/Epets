using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Epets.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpresaDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nit = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropietariosDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropietariosDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAnimalDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Animal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnimalDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MascotaDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMascota = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ColorOjos = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ColorPiel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Estatura = table.Column<float>(type: "real", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IdTipoAnimal = table.Column<int>(type: "int", nullable: true),
                    IdPropietario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MascotaDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MascotaDb_PropietariosDb_IdPropietario",
                        column: x => x.IdPropietario,
                        principalTable: "PropietariosDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MascotaDb_TipoAnimalDb_IdTipoAnimal",
                        column: x => x.IdTipoAnimal,
                        principalTable: "TipoAnimalDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicoDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarjetaProfesional = table.Column<int>(type: "int", nullable: false),
                    IdTipoAnimal = table.Column<int>(type: "int", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicoDb_EmpresaDb_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "EmpresaDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicoDb_TipoAnimalDb_IdTipoAnimal",
                        column: x => x.IdTipoAnimal,
                        principalTable: "TipoAnimalDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", maxLength: 12, nullable: false),
                    Recomendaciones = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Medicamento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IdMascota = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historia_MascotaDb_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "MascotaDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudVisitaDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMascota = table.Column<int>(type: "int", nullable: true),
                    IdPropietario = table.Column<int>(type: "int", nullable: true),
                    IdTipoAnimal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudVisitaDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudVisitaDb_MascotaDb_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "MascotaDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudVisitaDb_PropietariosDb_IdPropietario",
                        column: x => x.IdPropietario,
                        principalTable: "PropietariosDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudVisitaDb_TipoAnimalDb_IdTipoAnimal",
                        column: x => x.IdTipoAnimal,
                        principalTable: "TipoAnimalDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoSignoDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Temperatura = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    EstadoAnimo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSignoDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoSignoDb_Historia_Id",
                        column: x => x.Id,
                        principalTable: "Historia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historia_IdMascota",
                table: "Historia",
                column: "IdMascota");

            migrationBuilder.CreateIndex(
                name: "IX_MascotaDb_IdPropietario",
                table: "MascotaDb",
                column: "IdPropietario");

            migrationBuilder.CreateIndex(
                name: "IX_MascotaDb_IdTipoAnimal",
                table: "MascotaDb",
                column: "IdTipoAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDb_IdEmpresa",
                table: "MedicoDb",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDb_IdTipoAnimal",
                table: "MedicoDb",
                column: "IdTipoAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisitaDb_IdMascota",
                table: "SolicitudVisitaDb",
                column: "IdMascota");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisitaDb_IdPropietario",
                table: "SolicitudVisitaDb",
                column: "IdPropietario");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisitaDb_IdTipoAnimal",
                table: "SolicitudVisitaDb",
                column: "IdTipoAnimal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicoDb");

            migrationBuilder.DropTable(
                name: "SolicitudVisitaDb");

            migrationBuilder.DropTable(
                name: "TipoSignoDb");

            migrationBuilder.DropTable(
                name: "EmpresaDb");

            migrationBuilder.DropTable(
                name: "Historia");

            migrationBuilder.DropTable(
                name: "MascotaDb");

            migrationBuilder.DropTable(
                name: "PropietariosDb");

            migrationBuilder.DropTable(
                name: "TipoAnimalDb");
        }
    }
}
