using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class modelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "reviews",
                maxLength: 280,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "places",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "places",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_reviews_PlaceId",
                table: "reviews",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_places_PlaceId",
                table: "reviews",
                column: "PlaceId",
                principalTable: "places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reviews_places_PlaceId",
                table: "reviews");

            migrationBuilder.DropIndex(
                name: "IX_reviews_PlaceId",
                table: "reviews");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "reviews",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 280);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "places",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "places",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
