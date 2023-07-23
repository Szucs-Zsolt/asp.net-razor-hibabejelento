using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hibabejelento.Migrations
{
    /// <inheritdoc />
    public partial class IsInProcesshozzaadva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInProcess",
                table: "Tickets",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInProcess",
                table: "Tickets");
        }
    }
}
