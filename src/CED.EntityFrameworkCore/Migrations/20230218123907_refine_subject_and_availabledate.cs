using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CED.Migrations
{
    /// <inheritdoc />
    public partial class RefineSubjectAndAvailableDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppClassInformations_Subjects_SubjectId",
                table: "AppClassInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_AvailableDates_AppClassInformations_ClassInformationId",
                table: "AvailableDates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AvailableDates",
                table: "AvailableDates");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "AppSubjects");

            migrationBuilder.RenameTable(
                name: "AvailableDates",
                newName: "AppAvailableDates");

            migrationBuilder.RenameIndex(
                name: "IX_AvailableDates_ClassInformationId",
                table: "AppAvailableDates",
                newName: "IX_AppAvailableDates_ClassInformationId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppSubjects",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppSubjects",
                table: "AppSubjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAvailableDates",
                table: "AppAvailableDates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAvailableDates_AppClassInformations_ClassInformationId",
                table: "AppAvailableDates",
                column: "ClassInformationId",
                principalTable: "AppClassInformations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppClassInformations_AppSubjects_SubjectId",
                table: "AppClassInformations",
                column: "SubjectId",
                principalTable: "AppSubjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAvailableDates_AppClassInformations_ClassInformationId",
                table: "AppAvailableDates");

            migrationBuilder.DropForeignKey(
                name: "FK_AppClassInformations_AppSubjects_SubjectId",
                table: "AppClassInformations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppSubjects",
                table: "AppSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAvailableDates",
                table: "AppAvailableDates");

            migrationBuilder.RenameTable(
                name: "AppSubjects",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "AppAvailableDates",
                newName: "AvailableDates");

            migrationBuilder.RenameIndex(
                name: "IX_AppAvailableDates_ClassInformationId",
                table: "AvailableDates",
                newName: "IX_AvailableDates_ClassInformationId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AvailableDates",
                table: "AvailableDates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppClassInformations_Subjects_SubjectId",
                table: "AppClassInformations",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableDates_AppClassInformations_ClassInformationId",
                table: "AvailableDates",
                column: "ClassInformationId",
                principalTable: "AppClassInformations",
                principalColumn: "Id");
        }
    }
}
