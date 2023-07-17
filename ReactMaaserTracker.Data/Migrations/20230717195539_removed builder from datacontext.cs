using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactMaaserTracker.Data.Migrations
{
    public partial class removedbuilderfromdatacontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId1",
                table: "IncomeDeposits");

            migrationBuilder.DropIndex(
                name: "IX_IncomeDeposits_IncomeSourceId1",
                table: "IncomeDeposits");

            migrationBuilder.DropColumn(
                name: "IncomeSourceId1",
                table: "IncomeDeposits");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits",
                column: "IncomeSourceId",
                principalTable: "IncomeSources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits");

            migrationBuilder.AddColumn<int>(
                name: "IncomeSourceId1",
                table: "IncomeDeposits",
                type: "int",
                nullable: true);

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
    }
}
