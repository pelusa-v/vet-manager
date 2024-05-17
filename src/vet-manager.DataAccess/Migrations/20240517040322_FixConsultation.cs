using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vet_manager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixConsultation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Clients_ClientId",
                table: "Consultations");

            migrationBuilder.RenameColumn(
                name: "RaceId",
                table: "Pets",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Consultations",
                newName: "PetId");

            migrationBuilder.RenameIndex(
                name: "IX_Consultations_ClientId",
                table: "Consultations",
                newName: "IX_Consultations_PetId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Consultations",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Diagnosis",
                table: "Consultations",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_ClientId",
                table: "Pets",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Pets_PetId",
                table: "Consultations",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Clients_ClientId",
                table: "Pets",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Pets_PetId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Clients_ClientId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_ClientId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Consultations");

            migrationBuilder.DropColumn(
                name: "Diagnosis",
                table: "Consultations");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Pets",
                newName: "RaceId");

            migrationBuilder.RenameColumn(
                name: "PetId",
                table: "Consultations",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Consultations_PetId",
                table: "Consultations",
                newName: "IX_Consultations_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Clients_ClientId",
                table: "Consultations",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
