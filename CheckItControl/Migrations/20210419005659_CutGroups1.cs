using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckItControl.Data.Migrations
{
    public partial class CutGroups1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Groups_GroupId",
                table: "Disciplines");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Disciplines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Groups_GroupId",
                table: "Disciplines",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Groups_GroupId",
                table: "Disciplines");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Disciplines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Groups_GroupId",
                table: "Disciplines",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
