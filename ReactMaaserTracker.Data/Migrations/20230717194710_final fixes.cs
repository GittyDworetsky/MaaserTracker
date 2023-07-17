using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactMaaserTracker.Data.Migrations
{
    public partial class finalfixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomeIncomeSource");

            migrationBuilder.AddColumn<int>(
                name: "IncomeSourceId1",
                table: "IncomeDeposits",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IncomeDeposits_IncomeSourceId",
                table: "IncomeDeposits",
                column: "IncomeSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeDeposits_IncomeSourceId1",
                table: "IncomeDeposits",
                column: "IncomeSourceId1");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits",
                column: "IncomeSourceId",
                principalTable: "IncomeSources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId1",
                table: "IncomeDeposits",
                column: "IncomeSourceId1",
                principalTable: "IncomeSources",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId1",
                table: "IncomeDeposits");

            migrationBuilder.DropIndex(
                name: "IX_IncomeDeposits_IncomeSourceId",
                table: "IncomeDeposits");

            migrationBuilder.DropIndex(
                name: "IX_IncomeDeposits_IncomeSourceId1",
                table: "IncomeDeposits");

            migrationBuilder.DropColumn(
                name: "IncomeSourceId1",
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
    }
}
