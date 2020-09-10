using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M.A.R.S.Data.Migrations
{
    public partial class MyMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    Radio = table.Column<bool>(nullable: false),
                    TV = table.Column<bool>(nullable: false),
                    Print = table.Column<bool>(nullable: false),
                    Coupon = table.Column<bool>(nullable: false),
                    Banner = table.Column<bool>(nullable: false),
                    SM = table.Column<bool>(nullable: false),
                    EMail = table.Column<bool>(nullable: false),
                    SEA = table.Column<bool>(nullable: false),
                    Website = table.Column<bool>(nullable: false),
                    Shop = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
