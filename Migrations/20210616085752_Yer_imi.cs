using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Yer_imi : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "DrawNo",
                table: "Yer_imi",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "x",
                table: "Yer_imi",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "y",
                table: "Yer_imi",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "wkt",
                table: "Yer_imi",
                type: "string",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrawNo",
                table: "Yer_imi");

            migrationBuilder.DropColumn(
                name: "x",
                table: "Yer_imi");

            migrationBuilder.DropColumn(
                name: "y",
                table: "Yer_imi");

            migrationBuilder.DropColumn(
                name: "wkt",
                table: "Yer_imi");

        }
    }
}
