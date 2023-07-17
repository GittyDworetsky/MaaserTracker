using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactMaaserTracker.Data.Migrations
{
    public partial class changessourceproptoincomesourceid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDeposits_IncomeSources_IncomeSourceId",
                table: "IncomeDeposits");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "IncomeDeposits");

            migrationBuilder.AlterColumn<int>(
                name: "IncomeSourceId",
                table: "IncomeDeposits",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "IncomeSourceId",
                table: "IncomeDeposits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
