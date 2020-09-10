using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M.A.R.S.Data.Migrations
{
    public partial class MyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KPIConfigs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Radio_TKP = table.Column<double>(nullable: false),
                    TV_TKP = table.Column<double>(nullable: false),
                    TV_OTS = table.Column<double>(nullable: false),
                    Print_TKP = table.Column<double>(nullable: false),
                    Coupon_TKP = table.Column<double>(nullable: false),
                    Coupon_CTR = table.Column<double>(nullable: false),
                    Coupon_CR = table.Column<double>(nullable: false),
                    Banner_TKP = table.Column<double>(nullable: false),
                    Banner_CTR = table.Column<double>(nullable: false),
                    SM_TKP = table.Column<double>(nullable: false),
                    SM_CTR = table.Column<double>(nullable: false),
                    EMail_CTR = table.Column<double>(nullable: false),
                    Email_BR = table.Column<double>(nullable: false),
                    Email_OR = table.Column<double>(nullable: false),
                    SEA_CPC = table.Column<double>(nullable: false),
                    Website_CTR = table.Column<double>(nullable: false),
                    Website_BR = table.Column<double>(nullable: false),
                    Shop_CTR = table.Column<double>(nullable: false),
                    Shop_BR = table.Column<double>(nullable: false),
                    Shop_CR = table.Column<double>(nullable: false),
                    Shop_WAR = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPIConfigs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KPIConfigs");
        }
    }
}
