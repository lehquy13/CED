using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CED.Migrations
{
    /// <inheritdoc />
    public partial class ChangeClassSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "AppSubjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "AppSubjects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppSubjects",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "AppSubjects");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "AppSubjects");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppSubjects");
        }
    }
}
