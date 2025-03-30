using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiologicalSamplesTraceabilityAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixCollumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "SampleTypes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "SampleTypes",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "SampleTypes",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "SampleTypes",
                newName: "Created_at");
        }
    }
}
