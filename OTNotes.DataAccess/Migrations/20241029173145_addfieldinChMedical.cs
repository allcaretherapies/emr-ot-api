using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addfieldinChMedical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoughAfterDrink",
                table: "CHMedical",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JointPainDiscomfort",
                table: "CHMedical",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MedicalDiagnosisList",
                table: "CHMedical",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrenatalBirthHistory",
                table: "CHMedical",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProblemSwallowSwitch",
                table: "CHMedical",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StayNICU",
                table: "CHMedical",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoughAfterDrink",
                table: "CHMedical");

            migrationBuilder.DropColumn(
                name: "JointPainDiscomfort",
                table: "CHMedical");

            migrationBuilder.DropColumn(
                name: "MedicalDiagnosisList",
                table: "CHMedical");

            migrationBuilder.DropColumn(
                name: "PrenatalBirthHistory",
                table: "CHMedical");

            migrationBuilder.DropColumn(
                name: "ProblemSwallowSwitch",
                table: "CHMedical");

            migrationBuilder.DropColumn(
                name: "StayNICU",
                table: "CHMedical");
        }
    }
}
