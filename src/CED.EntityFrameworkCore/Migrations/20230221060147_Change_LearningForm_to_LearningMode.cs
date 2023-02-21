using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CED.Migrations
{
    /// <inheritdoc />
    public partial class ChangeLearningFormtoLearningMode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LearningFormality",
                table: "AppClassInformations",
                newName: "LearningMode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LearningMode",
                table: "AppClassInformations",
                newName: "LearningFormality");
        }
    }
}
