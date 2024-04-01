using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vet_manager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialDesign2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationAdditionals_Operations_OperationId1",
                table: "OperationAdditionals");

            migrationBuilder.DropIndex(
                name: "IX_OperationAdditionals_OperationId1",
                table: "OperationAdditionals");

            migrationBuilder.DropColumn(
                name: "OperationId1",
                table: "OperationAdditionals");

            migrationBuilder.AlterColumn<Guid>(
                name: "OperationId",
                table: "OperationAdditionals",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_OperationAdditionals_OperationId",
                table: "OperationAdditionals",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationAdditionals_Operations_OperationId",
                table: "OperationAdditionals",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationAdditionals_Operations_OperationId",
                table: "OperationAdditionals");

            migrationBuilder.DropIndex(
                name: "IX_OperationAdditionals_OperationId",
                table: "OperationAdditionals");

            migrationBuilder.AlterColumn<int>(
                name: "OperationId",
                table: "OperationAdditionals",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId1",
                table: "OperationAdditionals",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_OperationAdditionals_OperationId1",
                table: "OperationAdditionals",
                column: "OperationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationAdditionals_Operations_OperationId1",
                table: "OperationAdditionals",
                column: "OperationId1",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
