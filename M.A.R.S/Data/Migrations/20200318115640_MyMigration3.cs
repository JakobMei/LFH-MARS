using Microsoft.EntityFrameworkCore.Migrations;

namespace M.A.R.S.Data.Migrations
{
    public partial class MyMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email_OR",
                table: "KPIConfigs",
                newName: "EMail_OR");

            migrationBuilder.RenameColumn(
                name: "Email_BR",
                table: "KPIConfigs",
                newName: "EMail_BR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EMail_OR",
                table: "KPIConfigs",
                newName: "Email_OR");

            migrationBuilder.RenameColumn(
                name: "EMail_BR",
                table: "KPIConfigs",
                newName: "Email_BR");
        }
    }
}
