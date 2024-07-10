using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTematico.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AjustesPlant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cares_Plants_PlantId",
                table: "Cares");

            migrationBuilder.RenameColumn(
                name: "PlantId",
                table: "Cares",
                newName: "plantId");

            migrationBuilder.RenameIndex(
                name: "IX_Cares_PlantId",
                table: "Cares",
                newName: "IX_Cares_plantId");

            migrationBuilder.AlterColumn<int>(
                name: "plantId",
                table: "Cares",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cares_Plants_plantId",
                table: "Cares",
                column: "plantId",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cares_Plants_plantId",
                table: "Cares");

            migrationBuilder.RenameColumn(
                name: "plantId",
                table: "Cares",
                newName: "PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Cares_plantId",
                table: "Cares",
                newName: "IX_Cares_PlantId");

            migrationBuilder.AlterColumn<int>(
                name: "PlantId",
                table: "Cares",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Cares_Plants_PlantId",
                table: "Cares",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id");
        }
    }
}
