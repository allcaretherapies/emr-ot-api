using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BehavioralDiagnoses",
                table: "CHMedical",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DevelopmentalDiagnoses",
                table: "CHMedical",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BehavioralDiagnoses",
                table: "CHMedical");

            migrationBuilder.DropColumn(
                name: "DevelopmentalDiagnoses",
                table: "CHMedical");
        }
    }
}
