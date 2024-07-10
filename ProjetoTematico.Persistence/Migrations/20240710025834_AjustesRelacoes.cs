using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTematico.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AjustesRelacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cares_Plants_plantId",
                table: "Cares");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Cares_CareId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "CareId",
                table: "Works");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cares",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cares_Plants_PlantId",
                table: "Cares",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cares_Works_Id",
                table: "Cares",
                column: "Id",
                principalTable: "Works",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cares_Plants_PlantId",
                table: "Cares");

            migrationBuilder.DropForeignKey(
                name: "FK_Cares_Works_Id",
                table: "Cares");

            migrationBuilder.RenameColumn(
                name: "PlantId",
                table: "Cares",
                newName: "plantId");

            migrationBuilder.RenameIndex(
                name: "IX_Cares_PlantId",
                table: "Cares",
                newName: "IX_Cares_plantId");

            migrationBuilder.AddColumn<int>(
                name: "CareId",
                table: "Works",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cares",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_CareId",
                table: "Works",
                column: "CareId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cares_Plants_plantId",
                table: "Cares",
                column: "plantId",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Cares_CareId",
                table: "Works",
                column: "CareId",
                principalTable: "Cares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
