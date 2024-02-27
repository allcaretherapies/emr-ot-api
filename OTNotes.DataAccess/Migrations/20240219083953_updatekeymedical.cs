using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatekeymedical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChmedicalId",
                table: "CHMedical",
                newName: "CHMedicalId");

            migrationBuilder.RenameColumn(
                name: "ChgeneralId",
                table: "CHGeneral",
                newName: "CHGeneralId");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "CHMedical",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "CHMedical");

            migrationBuilder.RenameColumn(
                name: "CHMedicalId",
                table: "CHMedical",
                newName: "ChmedicalId");

            migrationBuilder.RenameColumn(
                name: "CHGeneralId",
                table: "CHGeneral",
                newName: "ChgeneralId");
        }
    }
}
