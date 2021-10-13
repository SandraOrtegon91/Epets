using Microsoft.EntityFrameworkCore.Migrations;

namespace Epets.App.Persistencia.Migrations
{
    public partial class Inicial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MascotaDb_MedicoDb_MedicoID",
                table: "MascotaDb");

            migrationBuilder.RenameColumn(
                name: "MedicoID",
                table: "MascotaDb",
                newName: "IdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_MascotaDb_MedicoID",
                table: "MascotaDb",
                newName: "IX_MascotaDb_IdMedico");

            migrationBuilder.AddForeignKey(
                name: "FK_MascotaDb_MedicoDb_IdMedico",
                table: "MascotaDb",
                column: "IdMedico",
                principalTable: "MedicoDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MascotaDb_MedicoDb_IdMedico",
                table: "MascotaDb");

            migrationBuilder.RenameColumn(
                name: "IdMedico",
                table: "MascotaDb",
                newName: "MedicoID");

            migrationBuilder.RenameIndex(
                name: "IX_MascotaDb_IdMedico",
                table: "MascotaDb",
                newName: "IX_MascotaDb_MedicoID");

            migrationBuilder.AddForeignKey(
                name: "FK_MascotaDb_MedicoDb_MedicoID",
                table: "MascotaDb",
                column: "MedicoID",
                principalTable: "MedicoDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
