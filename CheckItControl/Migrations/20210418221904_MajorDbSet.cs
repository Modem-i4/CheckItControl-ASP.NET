using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckItControl.Data.Migrations
{
    public partial class MajorDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisciplineGroup_Group_GroupsId",
                table: "DisciplineGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Subjects_SubjectId",
                table: "Disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Lesson_LessonId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Student_StudentId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Disciplines_DisciplineId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Group_GroupId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Quizzes_QuizId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Subjects_SubjectId",
                table: "Quizzes");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Group_GroupId",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Lesson",
                newName: "Lessons");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.RenameIndex(
                name: "IX_Student_GroupId",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_QuizId",
                table: "Lessons",
                newName: "IX_Lessons_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_GroupId",
                table: "Lessons",
                newName: "IX_Lessons_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_DisciplineId",
                table: "Lessons",
                newName: "IX_Lessons_DisciplineId");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Disciplines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplineGroup_Groups_GroupsId",
                table: "DisciplineGroup",
                column: "GroupsId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Subjects_SubjectId",
                table: "Disciplines",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Lessons_LessonId",
                table: "Grade",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Students_StudentId",
                table: "Grade",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Disciplines_DisciplineId",
                table: "Lessons",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Groups_GroupId",
                table: "Lessons",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Quizzes_QuizId",
                table: "Lessons",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Subjects_SubjectId",
                table: "Quizzes",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisciplineGroup_Groups_GroupsId",
                table: "DisciplineGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Subjects_SubjectId",
                table: "Disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Lessons_LessonId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Students_StudentId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Disciplines_DisciplineId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Groups_GroupId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Quizzes_QuizId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Subjects_SubjectId",
                table: "Quizzes");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Lessons",
                newName: "Lesson");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Student",
                newName: "IX_Student_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_QuizId",
                table: "Lesson",
                newName: "IX_Lesson_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_GroupId",
                table: "Lesson",
                newName: "IX_Lesson_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_DisciplineId",
                table: "Lesson",
                newName: "IX_Lesson_DisciplineId");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Quizzes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Disciplines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplineGroup_Group_GroupsId",
                table: "DisciplineGroup",
                column: "GroupsId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Subjects_SubjectId",
                table: "Disciplines",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Lesson_LessonId",
                table: "Grade",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Student_StudentId",
                table: "Grade",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Disciplines_DisciplineId",
                table: "Lesson",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Group_GroupId",
                table: "Lesson",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Quizzes_QuizId",
                table: "Lesson",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Subjects_SubjectId",
                table: "Quizzes",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Group_GroupId",
                table: "Student",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
