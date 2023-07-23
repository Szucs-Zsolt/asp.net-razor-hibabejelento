using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hibabejelento.Migrations
{
    /// <inheritdoc />
    public partial class proba003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "HelpdeskNote",
                table: "Tickets",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HelpdeskNote",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Tickets",
                type: "int",
                nullable: true);
        }
    }
}
