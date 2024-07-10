using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTematico.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AjustesRelacoes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cares_Plants_PlantId",
                table: "Cares");

            migrationBuilder.DropForeignKey(
                name: "FK_Cares_Works_Id",
                table: "Cares");

            migrationBuilder.DropIndex(
                name: "IX_Cares_PlantId",
                table: "Cares");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Cares_PlantId",
                table: "Cares",
                column: "PlantId");

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
    }
}
