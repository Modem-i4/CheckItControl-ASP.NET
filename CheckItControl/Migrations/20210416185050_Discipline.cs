using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckItControl.Data.Migrations
{
    public partial class Discipline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discipline_AspNetUsers_TeacherId",
                table: "Discipline");

            migrationBuilder.DropForeignKey(
                name: "FK_Discipline_Subjects_SubjectId",
                table: "Discipline");

            migrationBuilder.DropForeignKey(
                name: "FK_DisciplineGroup_Discipline_DisciplinesId",
                table: "DisciplineGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Discipline_DisciplineId",
                table: "Lesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Discipline",
                table: "Discipline");

            migrationBuilder.RenameTable(
                name: "Discipline",
                newName: "Disciplines");

            migrationBuilder.RenameIndex(
                name: "IX_Discipline_TeacherId",
                table: "Disciplines",
                newName: "IX_Disciplines_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Discipline_SubjectId",
                table: "Disciplines",
                newName: "IX_Disciplines_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Disciplines",
                table: "Disciplines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplineGroup_Disciplines_DisciplinesId",
                table: "DisciplineGroup",
                column: "DisciplinesId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_AspNetUsers_TeacherId",
                table: "Disciplines",
                column: "TeacherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Subjects_SubjectId",
                table: "Disciplines",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Disciplines_DisciplineId",
                table: "Lesson",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisciplineGroup_Disciplines_DisciplinesId",
                table: "DisciplineGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_AspNetUsers_TeacherId",
                table: "Disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Subjects_SubjectId",
                table: "Disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Disciplines_DisciplineId",
                table: "Lesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Disciplines",
                table: "Disciplines");

            migrationBuilder.RenameTable(
                name: "Disciplines",
                newName: "Discipline");

            migrationBuilder.RenameIndex(
                name: "IX_Disciplines_TeacherId",
                table: "Discipline",
                newName: "IX_Discipline_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Disciplines_SubjectId",
                table: "Discipline",
                newName: "IX_Discipline_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Discipline",
                table: "Discipline",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Discipline_AspNetUsers_TeacherId",
                table: "Discipline",
                column: "TeacherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Discipline_Subjects_SubjectId",
                table: "Discipline",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplineGroup_Discipline_DisciplinesId",
                table: "DisciplineGroup",
                column: "DisciplinesId",
                principalTable: "Discipline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Discipline_DisciplineId",
                table: "Lesson",
                column: "DisciplineId",
                principalTable: "Discipline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
