using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactMaaserTracker.Data.Migrations
{
    public partial class fixestoincome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_SourceId",
                table: "IncomeDeposits");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "IncomeDeposits",
                newName: "IncomeSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeDeposits_SourceId",
                table: "IncomeDeposits",
                newName: "IX_IncomeDeposits_IncomeSourceId");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "IncomeDeposits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits",
                column: "IncomeSourceId",
                principalTable: "IncomeSources",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "IncomeDeposits");

            migrationBuilder.RenameColumn(
                name: "IncomeSourceId",
                table: "IncomeDeposits",
                newName: "SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeDeposits_IncomeSourceId",
                table: "IncomeDeposits",
                newName: "IX_IncomeDeposits_SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_SourceId",
                table: "IncomeDeposits",
                column: "SourceId",
                principalTable: "IncomeSources",
                principalColumn: "Id");
        }
    }
}
