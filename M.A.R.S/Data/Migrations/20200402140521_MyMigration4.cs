using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M.A.R.S.Data.Migrations
{
    public partial class MyMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    Budget = table.Column<double>(nullable: false),
                    OpenBudget = table.Column<double>(nullable: false),
                    RadioBudget = table.Column<double>(nullable: false),
                    RadioPercentage = table.Column<double>(nullable: false),
                    RadioImpact = table.Column<double>(nullable: false),
                    TVBudget = table.Column<double>(nullable: false),
                    TVPercentage = table.Column<double>(nullable: false),
                    TVImpact = table.Column<double>(nullable: false),
                    PrintBudget = table.Column<double>(nullable: false),
                    PrintPercentage = table.Column<double>(nullable: false),
                    PrintImpact = table.Column<double>(nullable: false),
                    CouponBudget = table.Column<double>(nullable: false),
                    CouponPercentage = table.Column<double>(nullable: false),
                    CouponImpact = table.Column<double>(nullable: false),
                    BannerBudget = table.Column<double>(nullable: false),
                    BannerPercentage = table.Column<double>(nullable: false),
                    BannerImpact = table.Column<double>(nullable: false),
                    SMBudget = table.Column<double>(nullable: false),
                    SMPercentage = table.Column<double>(nullable: false),
                    SMImpact = table.Column<double>(nullable: false),
                    EMailBudget = table.Column<double>(nullable: false),
                    EMailPercentage = table.Column<double>(nullable: false),
                    EMailImpact = table.Column<double>(nullable: false),
                    SEABudget = table.Column<double>(nullable: false),
                    SEAPercentage = table.Column<double>(nullable: false),
                    SEAImpact = table.Column<double>(nullable: false),
                    WebsiteBudget = table.Column<double>(nullable: false),
                    WebsitePercentage = table.Column<double>(nullable: false),
                    WebsiteImpact = table.Column<double>(nullable: false),
                    ShopBudget = table.Column<double>(nullable: false),
                    ShopPercentage = table.Column<double>(nullable: false),
                    ShopImpact = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campaigns");
        }
    }
}
