using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniUti.Infra.Data.Migrations
{
    public partial class UpdateDomainLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Logs");
        }
    }
}
