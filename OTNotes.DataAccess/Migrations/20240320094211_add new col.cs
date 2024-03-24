using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addnewcol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnyPreviousSurgeries",
                table: "CHMedical",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrecautionsLimitations",
                table: "CHMedical",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnyPreviousSurgeries",
                table: "CHMedical");

            migrationBuilder.DropColumn(
                name: "PrecautionsLimitations",
                table: "CHMedical");
        }
    }
}
