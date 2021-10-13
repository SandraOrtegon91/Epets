using Microsoft.EntityFrameworkCore.Migrations;

namespace Epets.App.Persistencia.Migrations
{
    public partial class Inicial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Historia_HistoriaId",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Personas_MedicoId",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Personas_PropietarioId",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Empresa_EmpresaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_RecomendacionesCuidado_Historia_HistoriaId",
                table: "RecomendacionesCuidado");

            migrationBuilder.DropForeignKey(
                name: "FK_SignoVital_Historia_HistoriaId",
                table: "SignoVital");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVisita_Mascotas_MascotaId",
                table: "SolicitudVisita");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVisita_Mascotas_NombreMascotaId",
                table: "SolicitudVisita");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVisita_Personas_PropietarioId",
                table: "SolicitudVisita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SolicitudVisita",
                table: "SolicitudVisita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignoVital",
                table: "SignoVital");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecomendacionesCuidado",
                table: "RecomendacionesCuidado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EmpresaId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mascotas",
                table: "Mascotas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Especialidad",
                table: "SolicitudVisita");

            migrationBuilder.DropColumn(
                name: "TipoAnimal",
                table: "SolicitudVisita");

            migrationBuilder.DropColumn(
                name: "Signo",
                table: "SignoVital");

            migrationBuilder.DropColumn(
                name: "Valor_signo",
                table: "SignoVital");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "RecomendacionesCuidado");

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

            migrationBuilder.DropColumn(
                name: "TipoAnimal",
                table: "Mascotas");

            migrationBuilder.RenameTable(
                name: "SolicitudVisita",
                newName: "SolicitudVisitaDb");

            migrationBuilder.RenameTable(
                name: "SignoVital",
                newName: "SignoVitalDb");

            migrationBuilder.RenameTable(
                name: "RecomendacionesCuidado",
                newName: "RecomendacionesDb");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "PersonaDb");

            migrationBuilder.RenameTable(
                name: "Mascotas",
                newName: "MascotaDb");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "EmpresaDb");

            migrationBuilder.RenameColumn(
                name: "FechaVisita",
                table: "Historia",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "PropietarioId",
                table: "SolicitudVisitaDb",
                newName: "IdPropietario");

            migrationBuilder.RenameColumn(
                name: "NombreMascotaId",
                table: "SolicitudVisitaDb",
                newName: "IdMascota");

            migrationBuilder.RenameColumn(
                name: "MascotaId",
                table: "SolicitudVisitaDb",
                newName: "IdAnimal");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitudVisita_PropietarioId",
                table: "SolicitudVisitaDb",
                newName: "IX_SolicitudVisitaDb_IdPropietario");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitudVisita_NombreMascotaId",
                table: "SolicitudVisitaDb",
                newName: "IX_SolicitudVisitaDb_IdMascota");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitudVisita_MascotaId",
                table: "SolicitudVisitaDb",
                newName: "IX_SolicitudVisitaDb_IdAnimal");

            migrationBuilder.RenameColumn(
                name: "FechaHora",
                table: "SignoVitalDb",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "HistoriaId",
                table: "SignoVitalDb",
                newName: "SignoVital");

            migrationBuilder.RenameIndex(
                name: "IX_SignoVital_HistoriaId",
                table: "SignoVitalDb",
                newName: "IX_SignoVitalDb_SignoVital");

            migrationBuilder.RenameColumn(
                name: "FechaHora",
                table: "RecomendacionesDb",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "HistoriaId",
                table: "RecomendacionesDb",
                newName: "RecomendacionesCuidado");

            migrationBuilder.RenameIndex(
                name: "IX_RecomendacionesCuidado_HistoriaId",
                table: "RecomendacionesDb",
                newName: "IX_RecomendacionesDb_RecomendacionesCuidado");

            migrationBuilder.RenameColumn(
                name: "PropietarioId",
                table: "MascotaDb",
                newName: "IdPropietario");

            migrationBuilder.RenameColumn(
                name: "MedicoId",
                table: "MascotaDb",
                newName: "IdMedico");

            migrationBuilder.RenameColumn(
                name: "HistoriaId",
                table: "MascotaDb",
                newName: "IdHistoria");

            migrationBuilder.RenameIndex(
                name: "IX_Mascotas_PropietarioId",
                table: "MascotaDb",
                newName: "IX_MascotaDb_IdPropietario");

            migrationBuilder.RenameIndex(
                name: "IX_Mascotas_MedicoId",
                table: "MascotaDb",
                newName: "IX_MascotaDb_IdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_Mascotas_HistoriaId",
                table: "MascotaDb",
                newName: "IX_MascotaDb_IdHistoria");

            migrationBuilder.AlterColumn<string>(
                name: "Medicamento",
                table: "Historia",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recomendaciones",
                table: "Historia",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SignoVital",
                table: "Historia",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreMascota",
                table: "SolicitudVisitaDb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdAnimal",
                table: "SignoVitalDb",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdSigno",
                table: "SignoVitalDb",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "PersonaDb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "PersonaDb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "PersonaDb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "PersonaDb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Raza",
                table: "MascotaDb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreMascota",
                table: "MascotaDb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ColorPiel",
                table: "MascotaDb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ColorOjos",
                table: "MascotaDb",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoMascota",
                table: "MascotaDb",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "EmpresaDb",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "EmpresaDb",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMedico",
                table: "EmpresaDb",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolicitudVisitaDb",
                table: "SolicitudVisitaDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignoVitalDb",
                table: "SignoVitalDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecomendacionesDb",
                table: "RecomendacionesDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonaDb",
                table: "PersonaDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MascotaDb",
                table: "MascotaDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpresaDb",
                table: "EmpresaDb",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PropietariosDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdMascota = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropietariosDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropietariosDb_MascotaDb_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "MascotaDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropietariosDb_PersonaDb_Id",
                        column: x => x.Id,
                        principalTable: "PersonaDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoAnimalDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnimalDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoSignoDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    EstadoAnimo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSignoDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicoDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TarjetaProfesional = table.Column<int>(type: "int", nullable: false),
                    IdAnimal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicoDb_PersonaDb_Id",
                        column: x => x.Id,
                        principalTable: "PersonaDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicoDb_TipoAnimalDb_IdAnimal",
                        column: x => x.IdAnimal,
                        principalTable: "TipoAnimalDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historia_SignoVital",
                table: "Historia",
                column: "SignoVital");

            migrationBuilder.CreateIndex(
                name: "IX_SignoVitalDb_IdAnimal",
                table: "SignoVitalDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_SignoVitalDb_IdSigno",
                table: "SignoVitalDb",
                column: "IdSigno");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaDb_IdMedico",
                table: "EmpresaDb",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDb_IdAnimal",
                table: "MedicoDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_PropietariosDb_IdMascota",
                table: "PropietariosDb",
                column: "IdMascota");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaDb_MedicoDb_IdMedico",
                table: "EmpresaDb",
                column: "IdMedico",
                principalTable: "MedicoDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Historia_SignoVitalDb_SignoVital",
                table: "Historia",
                column: "SignoVital",
                principalTable: "SignoVitalDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MascotaDb_Historia_IdHistoria",
                table: "MascotaDb",
                column: "IdHistoria",
                principalTable: "Historia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MascotaDb_MedicoDb_IdMedico",
                table: "MascotaDb",
                column: "IdMedico",
                principalTable: "MedicoDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MascotaDb_PropietariosDb_IdPropietario",
                table: "MascotaDb",
                column: "IdPropietario",
                principalTable: "PropietariosDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecomendacionesDb_Historia_RecomendacionesCuidado",
                table: "RecomendacionesDb",
                column: "RecomendacionesCuidado",
                principalTable: "Historia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SignoVitalDb_Historia_SignoVital",
                table: "SignoVitalDb",
                column: "SignoVital",
                principalTable: "Historia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SignoVitalDb_TipoAnimalDb_IdAnimal",
                table: "SignoVitalDb",
                column: "IdAnimal",
                principalTable: "TipoAnimalDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SignoVitalDb_TipoSignoDb_IdSigno",
                table: "SignoVitalDb",
                column: "IdSigno",
                principalTable: "TipoSignoDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudVisitaDb_MascotaDb_IdMascota",
                table: "SolicitudVisitaDb",
                column: "IdMascota",
                principalTable: "MascotaDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudVisitaDb_PropietariosDb_IdPropietario",
                table: "SolicitudVisitaDb",
                column: "IdPropietario",
                principalTable: "PropietariosDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudVisitaDb_TipoAnimalDb_IdAnimal",
                table: "SolicitudVisitaDb",
                column: "IdAnimal",
                principalTable: "TipoAnimalDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaDb_MedicoDb_IdMedico",
                table: "EmpresaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_Historia_SignoVitalDb_SignoVital",
                table: "Historia");

            migrationBuilder.DropForeignKey(
                name: "FK_MascotaDb_Historia_IdHistoria",
                table: "MascotaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MascotaDb_MedicoDb_IdMedico",
                table: "MascotaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MascotaDb_PropietariosDb_IdPropietario",
                table: "MascotaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_RecomendacionesDb_Historia_RecomendacionesCuidado",
                table: "RecomendacionesDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SignoVitalDb_Historia_SignoVital",
                table: "SignoVitalDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SignoVitalDb_TipoAnimalDb_IdAnimal",
                table: "SignoVitalDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SignoVitalDb_TipoSignoDb_IdSigno",
                table: "SignoVitalDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVisitaDb_MascotaDb_IdMascota",
                table: "SolicitudVisitaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVisitaDb_PropietariosDb_IdPropietario",
                table: "SolicitudVisitaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVisitaDb_TipoAnimalDb_IdAnimal",
                table: "SolicitudVisitaDb");

            migrationBuilder.DropTable(
                name: "MedicoDb");

            migrationBuilder.DropTable(
                name: "PropietariosDb");

            migrationBuilder.DropTable(
                name: "TipoSignoDb");

            migrationBuilder.DropTable(
                name: "TipoAnimalDb");

            migrationBuilder.DropIndex(
                name: "IX_Historia_SignoVital",
                table: "Historia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SolicitudVisitaDb",
                table: "SolicitudVisitaDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignoVitalDb",
                table: "SignoVitalDb");

            migrationBuilder.DropIndex(
                name: "IX_SignoVitalDb_IdAnimal",
                table: "SignoVitalDb");

            migrationBuilder.DropIndex(
                name: "IX_SignoVitalDb_IdSigno",
                table: "SignoVitalDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecomendacionesDb",
                table: "RecomendacionesDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonaDb",
                table: "PersonaDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MascotaDb",
                table: "MascotaDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpresaDb",
                table: "EmpresaDb");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaDb_IdMedico",
                table: "EmpresaDb");

            migrationBuilder.DropColumn(
                name: "Recomendaciones",
                table: "Historia");

            migrationBuilder.DropColumn(
                name: "SignoVital",
                table: "Historia");

            migrationBuilder.DropColumn(
                name: "NombreMascota",
                table: "SolicitudVisitaDb");

            migrationBuilder.DropColumn(
                name: "IdAnimal",
                table: "SignoVitalDb");

            migrationBuilder.DropColumn(
                name: "IdSigno",
                table: "SignoVitalDb");

            migrationBuilder.DropColumn(
                name: "TipoMascota",
                table: "MascotaDb");

            migrationBuilder.DropColumn(
                name: "IdMedico",
                table: "EmpresaDb");

            migrationBuilder.RenameTable(
                name: "SolicitudVisitaDb",
                newName: "SolicitudVisita");

            migrationBuilder.RenameTable(
                name: "SignoVitalDb",
                newName: "SignoVital");

            migrationBuilder.RenameTable(
                name: "RecomendacionesDb",
                newName: "RecomendacionesCuidado");

            migrationBuilder.RenameTable(
                name: "PersonaDb",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "MascotaDb",
                newName: "Mascotas");

            migrationBuilder.RenameTable(
                name: "EmpresaDb",
                newName: "Empresa");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Historia",
                newName: "FechaVisita");

            migrationBuilder.RenameColumn(
                name: "IdPropietario",
                table: "SolicitudVisita",
                newName: "PropietarioId");

            migrationBuilder.RenameColumn(
                name: "IdMascota",
                table: "SolicitudVisita",
                newName: "NombreMascotaId");

            migrationBuilder.RenameColumn(
                name: "IdAnimal",
                table: "SolicitudVisita",
                newName: "MascotaId");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitudVisitaDb_IdPropietario",
                table: "SolicitudVisita",
                newName: "IX_SolicitudVisita_PropietarioId");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitudVisitaDb_IdMascota",
                table: "SolicitudVisita",
                newName: "IX_SolicitudVisita_NombreMascotaId");

            migrationBuilder.RenameIndex(
                name: "IX_SolicitudVisitaDb_IdAnimal",
                table: "SolicitudVisita",
                newName: "IX_SolicitudVisita_MascotaId");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "SignoVital",
                newName: "FechaHora");

            migrationBuilder.RenameColumn(
                name: "SignoVital",
                table: "SignoVital",
                newName: "HistoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_SignoVitalDb_SignoVital",
                table: "SignoVital",
                newName: "IX_SignoVital_HistoriaId");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "RecomendacionesCuidado",
                newName: "FechaHora");

            migrationBuilder.RenameColumn(
                name: "RecomendacionesCuidado",
                table: "RecomendacionesCuidado",
                newName: "HistoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_RecomendacionesDb_RecomendacionesCuidado",
                table: "RecomendacionesCuidado",
                newName: "IX_RecomendacionesCuidado_HistoriaId");

            migrationBuilder.RenameColumn(
                name: "IdPropietario",
                table: "Mascotas",
                newName: "PropietarioId");

            migrationBuilder.RenameColumn(
                name: "IdMedico",
                table: "Mascotas",
                newName: "MedicoId");

            migrationBuilder.RenameColumn(
                name: "IdHistoria",
                table: "Mascotas",
                newName: "HistoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_MascotaDb_IdPropietario",
                table: "Mascotas",
                newName: "IX_Mascotas_PropietarioId");

            migrationBuilder.RenameIndex(
                name: "IX_MascotaDb_IdMedico",
                table: "Mascotas",
                newName: "IX_Mascotas_MedicoId");

            migrationBuilder.RenameIndex(
                name: "IX_MascotaDb_IdHistoria",
                table: "Mascotas",
                newName: "IX_Mascotas_HistoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Medicamento",
                table: "Historia",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "Especialidad",
                table: "SolicitudVisita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoAnimal",
                table: "SolicitudVisita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Signo",
                table: "SignoVital",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Valor_signo",
                table: "SignoVital",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "RecomendacionesCuidado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

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

            migrationBuilder.AlterColumn<string>(
                name: "Raza",
                table: "Mascotas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "NombreMascota",
                table: "Mascotas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "ColorPiel",
                table: "Mascotas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "ColorOjos",
                table: "Mascotas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "TipoAnimal",
                table: "Mascotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolicitudVisita",
                table: "SolicitudVisita",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignoVital",
                table: "SignoVital",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecomendacionesCuidado",
                table: "RecomendacionesCuidado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mascotas",
                table: "Mascotas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EmpresaId",
                table: "Personas",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Historia_HistoriaId",
                table: "Mascotas",
                column: "HistoriaId",
                principalTable: "Historia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Personas_MedicoId",
                table: "Mascotas",
                column: "MedicoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Personas_PropietarioId",
                table: "Mascotas",
                column: "PropietarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Empresa_EmpresaId",
                table: "Personas",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecomendacionesCuidado_Historia_HistoriaId",
                table: "RecomendacionesCuidado",
                column: "HistoriaId",
                principalTable: "Historia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SignoVital_Historia_HistoriaId",
                table: "SignoVital",
                column: "HistoriaId",
                principalTable: "Historia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudVisita_Mascotas_MascotaId",
                table: "SolicitudVisita",
                column: "MascotaId",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudVisita_Mascotas_NombreMascotaId",
                table: "SolicitudVisita",
                column: "NombreMascotaId",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudVisita_Personas_PropietarioId",
                table: "SolicitudVisita",
                column: "PropietarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
