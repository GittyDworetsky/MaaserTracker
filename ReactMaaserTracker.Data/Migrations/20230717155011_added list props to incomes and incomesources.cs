using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactMaaserTracker.Data.Migrations
{
    public partial class addedlistpropstoincomesandincomesources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits");

            migrationBuilder.DropIndex(
                name: "IX_IncomeDeposits_IncomeSourceId",
                table: "IncomeDeposits");

            migrationBuilder.CreateTable(
                name: "IncomeIncomeSource",
                columns: table => new
                {
                    IncomeSourcesId = table.Column<int>(type: "int", nullable: false),
                    IncomesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeIncomeSource", x => new { x.IncomeSourcesId, x.IncomesId });
                    table.ForeignKey(
                        name: "FK_IncomeIncomeSource_IncomeDeposits_IncomesId",
                        column: x => x.IncomesId,
                        principalTable: "IncomeDeposits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncomeIncomeSource_IncomeSources_IncomeSourcesId",
                        column: x => x.IncomeSourcesId,
                        principalTable: "IncomeSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IncomeIncomeSource_IncomesId",
                table: "IncomeIncomeSource",
                column: "IncomesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomeIncomeSource");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeDeposits_IncomeSourceId",
                table: "IncomeDeposits",
                column: "IncomeSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits",
                column: "IncomeSourceId",
                principalTable: "IncomeSources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
