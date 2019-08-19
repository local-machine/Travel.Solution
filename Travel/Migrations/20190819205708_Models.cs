using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropColumn(
                name: "City",
                table: "reviews");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "reviews");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "reviews",
                newName: "Rating");

            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_places", x => x.PlaceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "places");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "reviews");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "reviews",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "reviews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "reviews",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });
        }
    }
}
