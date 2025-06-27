using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STime.Migrations
{
    /// <inheritdoc />
    public partial class AddedConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BandFestival_Festival_FestivalsId",
                table: "BandFestival");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Festival",
                table: "Festival");

            migrationBuilder.RenameTable(
                name: "Festival",
                newName: "Festivals");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Festivals",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Festivals",
                table: "Festivals",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BandFestival_Festivals_FestivalsId",
                table: "BandFestival",
                column: "FestivalsId",
                principalTable: "Festivals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BandFestival_Festivals_FestivalsId",
                table: "BandFestival");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Festivals",
                table: "Festivals");

            migrationBuilder.RenameTable(
                name: "Festivals",
                newName: "Festival");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Festival",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Festival",
                table: "Festival",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BandFestival_Festival_FestivalsId",
                table: "BandFestival",
                column: "FestivalsId",
                principalTable: "Festival",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
