using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodHamburguer.Migrations
{
    /// <inheritdoc />
    public partial class AddImgUrlToDish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Dishes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Dishes");
        }
    }
}
